namespace MvcAskAnswerProject.DataAccessLayer
{
    //Singleton Tasarım Modeli
    public class RepositoryBase
    {
        protected static DatabaseContext context;
        private static object _lock = new object();

        public RepositoryBase()
        {
            OlusturContext();

        }

        private static void OlusturContext()
        {
            if (context == null)
            {
                lock (_lock)
                {
                    context = new DatabaseContext();
                }
            }
        }
    }
}
