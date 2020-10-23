using Prism.Ioc;
using Prism.Unity;
using PrismAutowireViewModel.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PrismAutowireViewModel
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterDialog<ViewA>(nameof(ViewA));
            containerRegistry.RegisterDialog<ViewB>(nameof(ViewB));
        }
    }
}
