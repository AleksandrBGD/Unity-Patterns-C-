using UnityEngine;

// Фабрика для скрытия информации
// 
// Factory for hiding information
public class HiddenAccountFactory : MonoBehaviour, IAccountFactory
{
    public IPasswordView GetPasswordView(string password)
    {
        return new HiddenPasswordView(password);
    }

    public IEmailView GetEmailView(string email)
    {
        return new HiddenEmailView(email);
    }
}