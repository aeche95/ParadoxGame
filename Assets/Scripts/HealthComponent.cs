using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    private float health;
    private float maxHealth;

    float Health
    {
        get { return health; }
        set { health = Mathf.Clamp(value, 0, maxHealth); }
    }
        
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
