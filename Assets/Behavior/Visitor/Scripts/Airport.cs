using UnityEngine;

public abstract class Airport : MonoBehaviour
{
    public abstract void Accept(IAviateVisitor visitor);
}