using UnityEngine;

public class Item : MonoBehaviour , IInteractable, IStorable
{
    //[SerializeField]
    //ItemID id;

    [SerializeField]
    Texture2D iconTexture;

    [SerializeField]
    string Name;

    [SerializeField]
    int MaxStack = 1;

    [SerializeField]
    StorableID storeID;

    public StorableID ID { get => storeID; set => storeID = value; }

    public StorableID GetID()
    {
        return storeID;
    }


    //public ItemID GetItemID() 
    //{ 
    //    return id; 
    //}

    public void Interact(GameObject instigator)
    {
        throw new System.NotImplementedException();
    }

    public void Remove()
    {
        throw new System.NotImplementedException();
    }

    public void Store()
    {
        throw new System.NotImplementedException();
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
