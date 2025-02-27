namespace SoftwareDesignPattern.Chain_of_Responsibility
{
    public abstract class SupportHandler
    {
        protected SupportHandler nextHandler;
        public void SetNextHandler(SupportHandler handler)
        {
            this.nextHandler = handler;
        }
        public abstract void HandleRequest(int priority); // Must be imlemented by the subclasses
    }
}
