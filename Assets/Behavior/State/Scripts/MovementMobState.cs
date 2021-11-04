public class MovementMobState : MobState
{
    public override void Enable()
    {
        print("Enable: " + GetType());
    }

    public override void Refresh()
    {
        print("Update: " + GetType());
    }

    public override void Disable()
    {
        print("Disable: " + GetType());
    }
}