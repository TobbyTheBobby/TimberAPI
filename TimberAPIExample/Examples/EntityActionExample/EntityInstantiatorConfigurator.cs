using Bindito.Core;
using TimberbornAPI.DependencySystem;
using TimberbornAPI.EntityActionSystem;

namespace TimberAPIExample.Examples.EntityActionExample
{
    public class EntityInstantiatorConfigurator : IAutoConfiguratorInGame
    {
        public void Configure(IContainerDefinition containerDefinition)
        {
            containerDefinition.MultiBind<IEntityAction>().To<AddComponentExample>().AsSingleton();
            containerDefinition.MultiBind<IEntityAction>().To<TriggerActionExample>().AsSingleton();
        }
    }
}