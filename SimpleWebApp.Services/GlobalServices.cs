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
    public class GlobalServices : IGlobalServices
    {
        DataBaseContext dataBaseContext = new DataBaseContext();


        public bool SignUp(string firstName, string lastName, string userName, string passWord, DateTime birthDate)
        {
            if (dataBaseContext.Writers.Where(w => w.UserName == userName).FirstOrDefault() == null)
            {
                Writer writer = new Writer()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    UserName = userName,
                    Password = passWord,
                    BirthDate = birthDate
                };
                dataBaseContext.Writers.Add(writer);
                dataBaseContext.SaveChanges();

                return true;
            }
            else
                return false;

        }

        public bool SignIn(string userName, string passWord)
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