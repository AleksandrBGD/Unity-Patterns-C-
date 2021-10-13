// Стандартное представление Постройки
// 
// Standard representation of the Building

public class DefaultDesciptionBuilding : BuildingDecorator
{
    public DefaultDesciptionBuilding(IDescription wrapped) : base(wrapped) { }

    protected override string Get()
    {
        return _wrapped.GetDescription() + " Default building";
    }
}