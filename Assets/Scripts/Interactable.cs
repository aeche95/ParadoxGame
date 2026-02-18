using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public abstract class Interactable : MonoBehaviour, IInteractable
{
    public abstract void Interact(GameObject instigator);

}
