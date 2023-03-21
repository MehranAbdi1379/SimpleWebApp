using SimpleWebApp.DataBase;
using SimpleWebApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebApp.Services
{
    public class GlobalServices
    {
        DataBaseContext dataBaseContext;

        public GlobalServices(DataBaseContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;
        }

        public void SignUp(Writer writer)
        {
            dataBaseContext.Writers.Add(writer);
            dataBaseContext.SaveChanges();
        }

        public bool SignIn(string userName , string passWord)
        {
            if (dataBaseContext.Writers.Where(w => w.UserName == w.UserName && w.Password == passWord).FirstOrDefault() == null)
                return false;
            
            else
                return true;
        }

        public Writer GetWriterInfo(string userName)
        {
            return dataBaseContext.Writers.Where(w => w.UserName == userName).First();
        }
    }
}