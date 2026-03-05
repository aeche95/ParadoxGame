using System;
using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public static class InteractionExtension
{
    public static float GetMaxDistance(this Interaction interaction)
    {
        return interaction.maxDistance;
    }

}
public class LINQExample : MonoBehaviour
{
    int[] Array = { 1, 2, 3, 4, 5, 6, 7 };

    Interaction interaction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Array.First();
        IEnumerable<int> result = Array.Where<int>(x => x > 3);
        foreach (int x in result)
        {
            Debug.Log($"{x}");
        }

        interaction.GetMaxDistance();

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


