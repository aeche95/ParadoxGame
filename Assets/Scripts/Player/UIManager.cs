using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    ItemEvents itemEvents;

    [SerializeField]
    HUDController hudController;

    private void Awake()
    {
        itemEvents.ItemReceivedEvent.AddListener(OnItemReceived);
        itemEvents.ItemRemovedEvent.AddListener(OnItemRemoved);
    }

    void OnItemReceived(ItemData item)
    {
        if (hudController != null)
        {
            hudController.AddItemToInventory(item);
        }
    }

    void OnItemRemoved(StorableID ID)
    {

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
