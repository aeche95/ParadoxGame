using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "ScriptableObjects/Events/ItemEvents", fileName = "ItemsEventsSO")]
public class ItemEvents : ScriptableObject
{
    public UnityEvent<ItemData> ItemReceivedEvent = new();

    public UnityEvent<StorableID> ItemRemovedEvent = new();
}
