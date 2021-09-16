interface IAccountFactory
{
    IEmailView GetEmailView(string email);
    IPasswordView GetPasswordView(string password);
}