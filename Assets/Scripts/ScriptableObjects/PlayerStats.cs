using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStatsSO", menuName = "ScriptableObjects/Player")]
public class PlayerStats : ScriptableObject
{
    [SerializeField]
    public float startingHealth = 100;

    [SerializeField]
    public float maxShield = 100;

    [SerializeField]
    public float maxMana = 100;
}
