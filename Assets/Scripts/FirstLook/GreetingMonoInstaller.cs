using UnityEngine;
using Zenject;

namespace FirstLook
{
    public class GreetingMonoInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IGreeting>().To<Greeting>().AsSingle();
        }
    }
}