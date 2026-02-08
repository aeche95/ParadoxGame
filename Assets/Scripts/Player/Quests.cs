using System.Collections.Generic;
using UnityEngine;

public class Quests : MonoBehaviour
{

    Queue<Quest> questQueue = new();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddQuest(Quest quest)
    {
        questQueue.Enqueue(quest);
    }

    public Quest RemoveQuest(Quest quest)
    {
        return questQueue.Dequeue();
    }
}
