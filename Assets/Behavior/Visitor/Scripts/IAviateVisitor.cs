public interface IAviateVisitor
{
    void Visit(LandingStripAirport landingStrip);
    void Visit(RefillAirport refill);
}