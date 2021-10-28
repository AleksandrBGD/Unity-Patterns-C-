using UnityEngine;

// Базовый класс операций
// 
// Base class of operations
public abstract class Package : MonoBehaviour
{
    [SerializeField] protected GameObject _mediatorObj;
    protected IPackagedMediator Mediator => _mediatorObj.GetComponent<IPackagedMediator>();
}