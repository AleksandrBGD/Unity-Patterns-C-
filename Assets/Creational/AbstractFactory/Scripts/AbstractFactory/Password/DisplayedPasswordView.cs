
// Класс - полный Пароль
// 
// Class - Full Password
public class DisplayedPasswordView : IPasswordView
{
    private readonly string _password;

    public string Password => _password;

    public DisplayedPasswordView(string password)
    {
        _password = password;
    }
}