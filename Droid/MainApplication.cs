using System;
using System.Collections.Generic;
using Android.App;
using Android.Runtime;
using Bugreports.ViewModels;
using Caliburn.Micro;

namespace Bugreports.Droid
{
    [Application]
    public class MainApplication : CaliburnApplication
    {
        private SimpleContainer _container;

        public MainApplication(IntPtr handle, JniHandleOwnership transer)
            : base(handle, transer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();
            Initialize();
        }

        protected override void Configure()
        {
            _container = new SimpleContainer();
            _container.Instance(_container);

            _container.Singleton<App>();
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
                typeof(MainViewModel).Assembly
            };
        }
    }
}