namespace OneLogin.Repository.Abstractions{
 public interface ILoginRepository
    {
        string AuthenticateFacebookUser();
        string AuthenticateGoogleUser();
        string AuthenticateLinkedInUser();
        string AuthenticateOffice365User();
        string AuthenticateTwitterUser();
        string AuthenticateUsingAdharCard();
        string AuthenticateUsingCompanyEnterpriseSSO();
    }
}