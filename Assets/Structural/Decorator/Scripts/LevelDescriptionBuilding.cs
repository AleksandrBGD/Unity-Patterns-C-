// Уровневое представление Постройки
// 
// Level representation of the Building

public class LevelDescriptionBuilding : BuildingDecorator
{
    private readonly int _level;

    public LevelDescriptionBuilding(IDescription wrapped, int lvl) : base(wrapped)
    {
        _level = lvl;
    }

    protected override string Get()
    {
        return _wrapped.GetDescription() + " Level building" + " - " + _level.ToString() + " Level";
    }
}