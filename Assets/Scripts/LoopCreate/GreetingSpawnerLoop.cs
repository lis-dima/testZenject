using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GreetingSpawnerLoop : MonoBehaviour
{
    [Inject]
    GreetingConsumerLoop.Factory greetingConsumerLoopFactory;

    public float timeBetweenSpawn = 1.5f;
    public float timeSinceSpawn = 0;

    void Update()
    {
        timeSinceSpawn += Time.deltaTime;
        if(timeSinceSpawn > timeBetweenSpawn)
        {
            GreetingConsumerLoop consumer = greetingConsumerLoopFactory.Create();
            timeSinceSpawn = 0;
        }
    }
}
