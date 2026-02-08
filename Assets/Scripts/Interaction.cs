using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField]
    float maxDistance = 100.0f;

    [SerializeField]
    Interactable interactable = null;

    [SerializeField]
    GameObject source;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

        Interactable interactionComponent = other.gameObject.GetComponent<Interactable>();
        if (interactionComponent != null) {
            interactable = interactionComponent;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Interactable interactionComponent = other.gameObject.GetComponent<Interactable>();
        if (interactable != null && interactionComponent != null && interactable == interactionComponent)
        {
            interactable = null;
        }
    }

    public void OnInteract()
    {
        Debug.Log($"Interacting");
        if (interactable != null)
        {
            //interactable.Interact();
            //Debug.Log($"Interacting with {interactable.gameObject.name}");
        }
        Vector3 forwardVector = gameObject.transform.forward;
        Vector3 origin = source.transform.position;
        RaycastHit[] hits = Physics.RaycastAll(origin, forwardVector, maxDistance);
        Debug.DrawRay(origin, forwardVector*maxDistance, Color.azure, 20);
        foreach (RaycastHit hit in hits )
        {
            Debug.Log("found raycast hit, ");
            Interactable interactable = hit.rigidbody.gameObject.GetComponent<Interactable>();
            if (interactable != null)
            {
                interactable.Interact(gameObject);
                Debug.Log($"Interacting with {hit.rigidbody.gameObject.name}");
            }
        }
    }
}
