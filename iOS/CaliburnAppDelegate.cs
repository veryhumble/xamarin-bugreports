﻿using System;
using System.Collections.Generic;
using Caliburn.Micro;

namespace Bugreports.iOS
{
    public class CaliburnAppDelegate : CaliburnApplicationDelegate
    {
        private SimpleContainer _container;

        public CaliburnAppDelegate()
        {
            Initialize();
        }

        protected override void Configure()
        {
            _container = new SimpleContainer();
            _container.Instance(_container);

        }

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service);
        }

        protected override object GetInstance(Type service, string key)
        {
            return _container.GetInstance(service, key);
        }

        protected override IEnumerable<System.Reflection.Assembly> SelectAssemblies()
        {
            return new[]
            {
                GetType().Assembly,
                typeof(ViewModels.MainViewModel).Assembly
            };
        }
    }
}
