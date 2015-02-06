using Budget.Core.Abstract.Contexts;
using Should;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Budget.Specs.Steps
{
    [Binding]
    public class ViewSpentByCategorySteps : Steps
    {
        private ISpentByCategoryPresenter Presenter { get; set; }

        [Given(@"I created the category '(.*)'")]
        public void CreatedCategory(string categoryName)
        {
            Get<ICreateCategoryContext>().Exec(categoryName);
        }

        [Given(@"I spent (.*) in '(.*)'")]
        public void RegisterExpense(int amount, string categoryName)
        {
            Get<IRegisterExpenseContext>().Exec(amount, categoryName);
        }

        [When(@"I view the spent by category report")]
        public void ViewSpentByCategory()
        {
            Presenter = Get<IViewSpentByCategoryContext>().Exec();
        }

        [Then(@"the spent by category report should match")]
        public void SpentByCategoryReportShouldMatch(Table table)
        {
            table.CompareToSet(Presenter);
        }

        [Then(@"the total should be (.*)")]
        public void ThenTheTotalShouldBe(int total)
        {
            Presenter.Total.ShouldEqual(total);
        }
    }
}
