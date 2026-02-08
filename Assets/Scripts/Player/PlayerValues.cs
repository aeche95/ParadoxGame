using UnityEngine;

public class PlayerValues : MonoBehaviour
{

    [SerializeField]
    PlayerStats stats;

    float Health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Health = stats.startingHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
