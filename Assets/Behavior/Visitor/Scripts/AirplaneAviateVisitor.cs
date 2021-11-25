using UnityEngine;

public class AirplaneAviateVisitor : MonoBehaviour, IAviateVisitor
{
    public void Visit(LandingStripAirport landingStrip)
    {
        print("Landed Airplane: " + gameObject.name);
        landingStrip.PrepareLadder();
    }

    public void Visit(RefillAirport refill)
    {
        print("Fill up Airplane: " + gameObject.name);
    }
}