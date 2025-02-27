namespace SoftwareDesignPattern.Chain_of_Responsibility
{
    public class ConcreteHandlers
    {
        public class AgentHandler : SupportHandler
        {
            public override void HandleRequest(int priority)
            {
                if (priority <= 2)
                {
                    Console.WriteLine("Agent handled the request.");
                }
                else if (nextHandler != null)
                {
                    nextHandler.HandleRequest(priority);
                }
            }
        }

        public class ManagerHandler : SupportHandler
        {
            public override void HandleRequest(int priority)
            {
                if (priority <= 5)
                {
                    Console.WriteLine("Manager handled the request.");
                }
                else if (nextHandler != null)
                {
                    nextHandler.HandleRequest(priority);
                }
            }
        }

        public class DirectorHandler : SupportHandler
        {
            public override void HandleRequest(int priority)
            {
                Console.WriteLine("Director handled the request.");
            }
        }

    }
}
