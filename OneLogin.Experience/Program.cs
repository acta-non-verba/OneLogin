using System;
using OneLogin.Repository;
namespace OneLogin.Experience
{
    class Program
    {
        public enum SSOMethod
        {
            CompanySSO = 7,
            Google = 1,
            Facebook = 2,
            Twitter = 3,
            LinkedIn = 4,
            Aadhar = 5,
            Office365 = 6
        }
        static void Main(string[] args)
        {
            int loginMethod = AskUserLoginPreference();
            LoginRepository repository = new LoginRepository();
            string authenticationStatus = "";
            switch (loginMethod)
            {
                case 1:
                    authenticationStatus = repository.AuthenticateGoogleUser();
                    break;
                case 2:
                    authenticationStatus = repository.AuthenticateFacebookUser();
                    break;
                case 3:
                    authenticationStatus = repository.AuthenticateTwitterUser();
                    break;
                case 4:
                    authenticationStatus = repository.AuthenticateLinkedInUser();
                    break;
                case 5:
                    authenticationStatus = repository.AuthenticateUsingAdharCard();
                    break;
                case 6:
                    authenticationStatus = repository.AuthenticateOffice365User();
                    break;
                case 7:
                    authenticationStatus = repository.AuthenticateUsingCompanyEnterpriseSSO();
                    break;
                default:
                    authenticationStatus = repository.AuthenticateUsingCompanyEnterpriseSSO();
                    break;
            }
            Console.WriteLine(authenticationStatus);
        }
        private static int AskUserLoginPreference()
        {
            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine("Login using " + i + "." + (SSOMethod)i);
            }
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
