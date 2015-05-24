using System;
using System.Collections.Generic;
using System.Windows;
using Caliburn.Micro;

namespace AsyncButtonDemo.Caliburn
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<MainViewModel>();
        }
    }
}
