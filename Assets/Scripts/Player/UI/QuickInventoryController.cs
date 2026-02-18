using UnityEngine;
using UnityEngine.UI;

public class QuickInventoryController : MonoBehaviour
{
    [SerializeField]
    Image[] slotIcons;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddItem(ItemData item)
    {
        Image freeSlot = GetFreeImage();
        if ( freeSlot != null)
        {
            freeSlot.sprite = item.iconTexture;
        }
    }

    Image GetFreeImage()
    {
        Image result = null;
        foreach (Image slot in slotIcons)
        {
            if (slot.sprite == null)
            {
                result = slot;
                return result;
            }
        }
        return result;
    }

}
