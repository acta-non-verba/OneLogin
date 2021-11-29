namespace OneLogin.Repository
{
    public class FinanceLogin : ILoginRepository
    {
        public string AuthenticateFacebookUser()
        {
            throw new System.NotImplementedException();
        }

        public string AuthenticateGoogleUser()
        {
            throw new System.NotImplementedException();
        }

        public string AuthenticateLinkedInUser()
        {
            throw new System.NotImplementedException();
        }

        public string AuthenticateOffice365User()
        {
            return "Office 365 authentication status";
        }

        public string AuthenticateTwitterUser()
        {
            throw new System.NotImplementedException();
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