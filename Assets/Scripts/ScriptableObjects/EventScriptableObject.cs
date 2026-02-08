using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName ="ScriptableObjects/Enemy", fileName = "EnemyEventsSO")]
public class EventScriptableObject : ScriptableObject
{
    [SerializeField]
    public UnityEvent<int> EnemyWarning = new();
}
