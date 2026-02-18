using UnityEngine;

public class HUDController : MonoBehaviour
{
    [SerializeField]
    QuickInventoryController inventoryController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddItemToInventory(ItemData item)
    {
        inventoryController.AddItem(item);
    }
}
