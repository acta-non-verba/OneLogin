using OneLogin.Repository.Abstractions;

namespace OneLogin.Repository
{
    public class FinanceLogin : IOffice365LoginRepository,
                                IAadharLoginRepository,
                                IEnterpriseSSO
    {
        public string AuthenticateOffice365User()
        {
            return "Office 365 authentication status";
        }

        public string AuthenticateUsingAdharCard()
        {
            return "Aadhar authentication status";
        }

        public string AuthenticateUsingCompanyEnterpriseSSO()
        {
            return "company sso authentication status";
        }
    }
}