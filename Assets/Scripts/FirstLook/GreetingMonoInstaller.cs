using UnityEngine;
using Zenject;

public class GreetingMonoInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IGreeting>().To<Greeting>().AsSingle();
    }
}