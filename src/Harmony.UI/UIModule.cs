using Harmony.Common;
using Harmony.UI.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Harmony.UI
{
    public class UIModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider) 
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RequestNavigate(RegionNames.ContentRegion, nameof(MainView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry) 
        {
            containerRegistry.RegisterForNavigation<MainView>();
        }
    }
}