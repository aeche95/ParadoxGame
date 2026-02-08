using UnityEngine;

public interface IInteractable
{
    public void Interact(GameObject instigator);
}

public interface IUsable
{
    public void Use();
}

public interface IConsumable
{
    public void Consume();
}

public interface IStorable
{
    StorableID ID { get; set; }
    public void Store();
    public void Remove();
}
   