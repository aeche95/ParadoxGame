using UnityEngine;

public class Item : Interactable, IStorable
{
    [SerializeField]
    ItemData itemDataSO;

    AudioSource AudioSource;

    ParticleSystem vfx;

    public StorableID ID { get => itemDataSO.ID; }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
        vfx = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void Interact(GameObject instigator)
    {
        if (AudioSource != null)
        {
            AudioSource.Play();
        }

        if (vfx != null)
        {
            vfx.Play();
        }
    }

    public void Remove()
    {
        throw new System.NotImplementedException();
    }

    public void Store()
    {
        throw new System.NotImplementedException();
    }

    
}
