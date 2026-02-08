using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour, IInteractable
{
    [SerializeField]
    List<IStorable> itemsList = new();

   
    public void AddItem(Item item)
    {
        itemsList.Add(item);
    }

    public void RemoveItem(StorableID ItemID)
    {
        foreach(IStorable item in itemsList)
        {
            if (item.ID == ItemID)
            {
                itemsList.Remove(item);
            }
        }
    }

    public IStorable FindItem(StorableID ItemID)
    {
        foreach (IStorable item in itemsList)
        {
            if (item.ID == ItemID)
            {
                return item;
            }
        }
        return null;
    }

    public bool HasItem(StorableID ItemID)
    {
        foreach (IStorable item in itemsList)
        {
            if (item.ID == ItemID)
            {
                return true;
            }
        }
        return false;
    }

    public void Interact(GameObject instigator)
    {
        Debug.Log($"Interacted with {gameObject.name}");
        return;

    }
}
