using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Diet.Droid.Renderers;
using Xamarin.Forms.Platform.Android;
using System.Drawing;
using Android.Graphics;

[assembly: ExportRenderer(typeof(NavigationPage), typeof(CustomNavigationRenderer_Droid))]
namespace Diet.Droid.Renderers
{
    class CustomNavigationRenderer_Droid: Xamarin.Forms.Platform.Android.AppCompat.NavigationPageRenderer
    {
        //public Android.Support.V7.Widget.Toolbar toolbar;

        //public override void OnViewAdded(Android.Views.View child)
        //{
        //    base.OnViewAdded(child);
        //    if (child.GetType() == typeof(Android.Support.V7.Widget.Toolbar))
        //    {
        //        toolbar = (Android.Support.V7.Widget.Toolbar)child;
        //        toolbar.ChildViewAdded += Toolbar_ChildViewAdded;
        //    }
        //}

        //public void Toolbar_ChildViewAdded(object sender, ChildViewAddedEventArgs e)
        //{
        //    var view = e.Child.GetType();
        //    if (e.Child.GetType() == typeof(Android.Widget.TextView))
        //    {
        //        var textView = (Android.Widget.TextView)e.Child;
        //        var spaceFont1 = Typeface.CreateFromAsset(Xamarin.Forms.Forms.Context.ApplicationContext.Assets, @"\Assets\Averta-Bold.ttf");
        //        textView.Typeface = spaceFont1;
        //        toolbar.ChildViewAdded -= Toolbar_ChildViewAdded;
        //    }
        //}
    }
}