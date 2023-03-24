using SimpleWebApp.Domain;

namespace SimpleWebApp.Services
{
    public interface IGlobalServices
    {
        Writer GetWriterInfo(string userName);
        bool SignIn(string userName, string passWord);
        bool SignUp(string firstName, string lastName, string userName, string passWord, DateTime birthDate);
    }
}