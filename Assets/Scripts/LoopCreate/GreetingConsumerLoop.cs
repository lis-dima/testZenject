using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GreetingConsumerLoop : MonoBehaviour
{
    private IGreeting greeting;

    [Inject]
    public void Construct(IGreeting greeting)
    {
        this.greeting = greeting;
    }
    // Update is called once per frame
    void Start()
    {
        Debug.Log(greeting.GetGreeting());
    }

    public class Factory : PlaceholderFactory<GreetingConsumerLoop> { }
}
