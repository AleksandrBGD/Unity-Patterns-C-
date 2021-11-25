using UnityEngine;

public class StartupTest : MonoBehaviour
{
    [SerializeField] private Airport _landingStrip, _refillAirport;
    [SerializeField] private GameObject _helicopterVisitorObj, _airplaneVisitorObj;

    private void Start()
    {
        var helicopterVisitor = _helicopterVisitorObj.GetComponent<IAviateVisitor>();
        var airplaneVisitor = _airplaneVisitorObj.GetComponent<IAviateVisitor>();

        _landingStrip.Accept(helicopterVisitor);
        _refillAirport.Accept(helicopterVisitor);

        _landingStrip.Accept(airplaneVisitor);
        _refillAirport.Accept(airplaneVisitor);
    }
}