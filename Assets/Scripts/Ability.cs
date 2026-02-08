using UnityEngine;

public class Ability : MonoBehaviour, IInteractable
{
    public void Interact(GameObject instigator)
    {
        Abilities abilitiesComponent = instigator.GetComponent<Abilities>();
        if (abilitiesComponent != null)
        {

        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
