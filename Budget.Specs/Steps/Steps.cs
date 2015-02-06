using Ninject;

namespace Budget.Specs.Steps
{
    public class Steps
    {
        private IKernel Kernel { get; set; }

        public Steps()
        {
            Kernel = new StandardKernel(new Module());
        }

        protected T Get<T>()
        {
            return Kernel.Get<T>();
        }
    }
}