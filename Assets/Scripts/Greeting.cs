using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Greeting : IGreeting
{
    public string GetGreeting()
    {
        return "Hello, Jedi";
    }
}
