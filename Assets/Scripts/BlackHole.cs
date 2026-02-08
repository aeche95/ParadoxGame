using UnityEngine;

public class BlackHole : MonoBehaviour
{
    [SerializeField]
    float magnitude;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        Vector3 direction = (transform.position - other.gameObject.transform.position);
        direction = direction.normalized * magnitude;
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(direction, ForceMode.Force);
        }
    }
}
