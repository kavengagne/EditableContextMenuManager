﻿using System;
using System.Windows;
using GalaSoft.MvvmLight.Threading;


namespace MenuManager.App
{
    public partial class App
    {
        static App()
        {
            DispatcherHelper.Initialize();
        }

        public App()
        {
        }


        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
        }
    }
}
