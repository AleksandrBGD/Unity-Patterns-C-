
// Класс - не полный Email(скрытый)
// 
// Class-incomplete Email(hidden)
public class HiddenEmailView : IEmailView
{
    private readonly string _email;

    public string Email => GetHiddenEmail();

    public HiddenEmailView(string email)
    {
        _email = email;
    }

    // Скрывваем информацию до символа @
    // 
    // Hiding the information up to the symbol @
    private string GetHiddenEmail()
    {
        var login = _email.Substring(0, _email.IndexOf('@'));
        var hidden = string.Empty;

        for (int i = 0; i < login.Length; i++)
        {
            hidden += "*";
        }

        var other = _email.Substring(_email.IndexOf('@'));
        var result = hidden + other;

        return result;
    }
}