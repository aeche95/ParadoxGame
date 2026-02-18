using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Items/ItemData", fileName = "ItemDataSO")]
public class ItemData : ScriptableObject
{
    [SerializeField]
    public StorableID ID;
    
    [SerializeField]
    public Sprite iconTexture;

    [SerializeField]
    public string Name;

    [SerializeField]
    public int MaxStack = 1;
}
