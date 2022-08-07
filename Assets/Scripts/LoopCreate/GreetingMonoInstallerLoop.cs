using UnityEngine;
using Zenject;

public class GreetingMonoInstallerLoop : MonoInstaller
{
    [SerializeField]
    GreetingConsumerLoop pref_GreetingConsumerLoop;
    public override void InstallBindings()
    {
        Container.Bind<IGreeting>().To<Greeting>().AsSingle();
        Container.BindFactory<GreetingConsumerLoop, GreetingConsumerLoop.Factory>().FromComponentInNewPrefab(pref_GreetingConsumerLoop);
    }
}