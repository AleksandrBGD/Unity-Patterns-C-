using UnityEngine;

public class HelicopterAviateVisitor : MonoBehaviour, IAviateVisitor
{
    public void Visit(LandingStripAirport landingStrip)
    {
        print("Landed Helicopter: " + gameObject.name);
    }

    public void Visit(RefillAirport refill)
    {
        print("Fill up Helicopter: " + gameObject.name);
    }
}