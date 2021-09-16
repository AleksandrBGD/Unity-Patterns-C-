
// Класс - полный Email
// 
// Class - Full Email
public class DisplayedEmailView : IEmailView
{
    private readonly string _email;

    public string Email => _email;

    public DisplayedEmailView(string email)
    {
        _email = email;
    }
}