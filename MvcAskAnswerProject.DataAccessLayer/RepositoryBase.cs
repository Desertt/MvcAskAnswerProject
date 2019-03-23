using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcAskAnswerProject.DataAccessLayer
{
    //Singleton Tasarım Modeli
    public class RepositoryBase
    {
        protected static DatabaseContext context;


        public RepositoryBase()
        {
            OlusturContext();            

        }

        private static void OlusturContext()
        {
            if (context==null )
            {
                context = new DatabaseContext();
            }
        }
    }
}
