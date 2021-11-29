using System;

namespace OneLogin.Repository
{
    public class BeInTouchLoginRepository : ILoginRepository
    {
        public BeInTouchLoginRepository()
        {
        }

        public string AuthenticateUsingCompanyEnterpriseSSO()
        {
            return "company sso authentication status";
        }
        public string AuthenticateGoogleUser()
        {
            return "google authentication status";
        }
        public string AuthenticateFacebookUser()
        {
            return "Facebook user authentication status";
        }
        public string AuthenticateTwitterUser()
        {
            return "Twitter user authentication status";
        }
        public string AuthenticateLinkedInUser()
        {
            return "LikedIn user authentication status";
        }
        public string AuthenticateUsingAdharCard()
        {
            return "Aadhar authentication status";
        }
        public string AuthenticateOffice365User()
        {
            return "Office 365 authentication status";
        }

    }
}
