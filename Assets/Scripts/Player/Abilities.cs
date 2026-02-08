using System.Collections.Generic;
using UnityEngine;

public class Abilities : MonoBehaviour
{
    Stack<Ability> abilitiesStack;

    [SerializeField]
    EventScriptableObject eventsSO;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddAbility(Ability ability)
    {
        abilitiesStack.Push(ability);
    }

    public void RemoveAbility(Ability ability)
    {
        abilitiesStack.Pop();
    }

    public Ability GetAbility(int index)
    {
        return abilitiesStack.Peek();
    }
}
