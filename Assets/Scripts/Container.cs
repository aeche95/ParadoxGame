using UnityEngine;

public class Container : MonoBehaviour, IInteractable
{
    [SerializeField]
    Example[] objects = {new Example(), new Example() };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddExample(Example example)
    {
        objects.SetValue(example, 0);
    }

    public void Interact()
    {
        Debug.Log($"Interacted with {gameObject.name}");
    }
}
