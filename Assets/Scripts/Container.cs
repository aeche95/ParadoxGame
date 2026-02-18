using System.Collections.Generic;
using UnityEngine;

public class Container : Interactable
{
    [SerializeField]
    List<StorableID> IDList = new();

    [SerializeField]
    ItemDatabase itemDatabase;

    [SerializeField]
    ItemEvents itemEvents;

    private void Start()
    {
        foreach (StorableID ID in IDList)
        {
            ItemData data = FindItem(ID);
            itemEvents.ItemReceivedEvent.Invoke(data);
        }
    }
    public void AddItem(StorableID ID)
    {
        IDList.Add(ID);
        ItemData data = FindItem(ID);
        itemEvents.ItemReceivedEvent.Invoke(data);
    }

    public void RemoveItem(StorableID ID)
    {
        if (IDList.Contains(ID))
        {
            IDList.Remove(ID);
            itemEvents.ItemRemovedEvent.Invoke(ID);
        }
    }

    public ItemData FindItem(StorableID ItemID)
    {
        return itemDatabase.GetItem(ItemID);
    }

    public bool HasItem(StorableID ItemID)
    {
        return IDList.Contains(ItemID);
    }

    public override void Interact(GameObject instigator)
    {
        Debug.Log($"Interacted with {gameObject.name}");
        return;

    }
}
