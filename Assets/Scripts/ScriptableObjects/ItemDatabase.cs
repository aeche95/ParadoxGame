using System.Linq;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Items/ItemsDatabase", fileName = "ItemsDatabaseSO")]
public class ItemDatabase : ScriptableObject
{
    [SerializeField]
    public ItemData[] Items;

    public ItemData GetItem(StorableID ID)
    {
        return Items.First(x => x.ID == ID);
    }
}
