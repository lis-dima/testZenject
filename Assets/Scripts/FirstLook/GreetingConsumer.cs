using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace FirstLook
{
    public class GreetingConsumer : MonoBehaviour
    {
        [Inject]
        IGreeting greeting;

        // Update is called once per frame
        void Start()
        {
            Debug.Log("Start");
            Debug.Log(greeting.GetGreeting());
        }
    }
}
