using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GreetingConsumer : MonoBehaviour
{
    [Inject]
    IGreeting greeting;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(greeting.GetGreeting());
    }
}
