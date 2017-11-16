//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//
//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;
//using Diet.Util;
//using Ninject;
//using Ninject.Parameters;
//
//namespace Diet.Droid.Utils
//{
//    class DroidDependencyResolver : IDependencyResolver
//    {
//        public IKernel Kernel;
//
//        public DroidDependencyResolver(IKernel kernel)
//        {
//            Kernel = kernel;
//        }
//        public object GetService(Type serviceType)
//        {
//            return Kernel.TryGet(serviceType, new IParameter[0]);
//        }
//
//        public IEnumerable<object> GetServices(Type serviceType)
//        {
//            return Kernel.GetAll(serviceType, new IParameter[0]);
//        }
//    }
//}