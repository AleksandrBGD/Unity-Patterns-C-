// Базовый абстрактный класс оберток
// 
// Basic abstract wrapper class

public abstract class BuildingDecorator : IDescription
{
    // Обьект
    // 
    // Object
    protected readonly IDescription _wrapped;

    public BuildingDecorator(IDescription wrapped)
    {
        _wrapped = wrapped;
    }

    // Провести через обертку
    // 
    // Pass through the wrapper
    public string GetDescription()
    {
        return "Foundation" + " - " + Get();
    }

    protected abstract string Get();
}