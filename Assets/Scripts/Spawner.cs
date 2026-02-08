using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    List<GameObject> enemiesList;

    Stack<GameObject> enemies = new();


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (GameObject enemy in enemiesList)
        {
            enemies.Push(enemy);
        }
        int count = enemies.Count;
        for (int i = 0; i < count; i++)
        {
            GameObject.Instantiate(enemies.Pop(), gameObject.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
