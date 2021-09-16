using UnityEngine;

// Класс для теста Абстрактной фабрики
// 
// Class for the Abstract Factory test
public class StartupTest : MonoBehaviour
{
    [SerializeField] private string _emal, _password;
    [SerializeField] private GameObject _accountFactory;

    private void Start()
    {
        var factory = _accountFactory.GetComponent<IAccountFactory>();

        // Получаем Email и Пароль в зависимости от фабрики
        // 
        // We get an Email and a Password depending on the factory
        var emailView = factory.GetEmailView(_emal);
        var passwordView = factory.GetPasswordView(_password);

        // Выводим значения
        // 
        // Output the values
        print("Email: " + emailView.Email);
        print("Password: " + passwordView.Password);
    }
}