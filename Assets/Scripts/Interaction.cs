using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField]
    float maxDistance = 100.0f;

    [SerializeField]
    Interactable interactable = null;

    [SerializeField]
    GameObject source;

    [SerializeField]
    LayerMask layerMask;

    public void OnInteract()
    {
        Debug.Log($"Interacting");
        if (interactable != null)
        {
            //interactable.Interact();
            //Debug.Log($"Interacting with {interactable.gameObject.name}");
        }
        Vector3 forwardVector = source.transform.forward;
        Vector3 origin = source.transform.position;
        RaycastHit[] hits = Physics.RaycastAll(origin, forwardVector, maxDistance, layerMask);
        Debug.DrawRay(origin, forwardVector * maxDistance, Color.azure, 20);
        foreach (RaycastHit hit in hits )
        {
            Debug.Log($"found raycast hit, {hit.rigidbody.gameObject.name}");
            Interactable interactable = hit.rigidbody.gameObject.GetComponent<Interactable>();
            if (interactable != null)
            {
                interactable.Interact(gameObject);
                Debug.Log($"Interacting with {hit.rigidbody.gameObject.name}");
            }
        }
    }
}
