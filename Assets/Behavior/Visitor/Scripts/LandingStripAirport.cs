public class LandingStripAirport : Airport
{
    public override void Accept(IAviateVisitor visitor)
    {
        visitor.Visit(this);
    }

    public void PrepareLadder()
    {
        print("Ladder Ready");
    }
}