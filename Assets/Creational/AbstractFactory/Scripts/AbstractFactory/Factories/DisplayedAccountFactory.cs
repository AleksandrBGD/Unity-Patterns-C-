using UnityEngine;

// Фабрика для отображения полной информации
// 
// Factory for displaying complete information
public class DisplayedAccountFactory : MonoBehaviour, IAccountFactory
{
    public IPasswordView GetPasswordView(string password)
    {
        return new DisplayedPasswordView(password);
    }

    public IEmailView GetEmailView(string email)
    {
        return new DisplayedEmailView(email);
    }
}