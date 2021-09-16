
// Класс - не полный Пароль(скрытый полностью)
// 
// Class-incomplete Password(completely hidden)
public class HiddenPasswordView : IPasswordView
{
    private readonly string _password;

    public string Password => GetHiddenPassword();

    public HiddenPasswordView(string password)
    {
        _password = password;
    }

    // Скрываем пароль полностью
    // 
    // Hiding the password completely
    private string GetHiddenPassword()
    {
        var password = string.Empty;

        for (int i = 0; i < _password.Length; i++)
        {
            password += "*";
        }

        return password;
    }
}