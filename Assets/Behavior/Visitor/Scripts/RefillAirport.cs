public class RefillAirport : Airport
{
    public override void Accept(IAviateVisitor visitor)
    {
        visitor.Visit(this);
    }
}