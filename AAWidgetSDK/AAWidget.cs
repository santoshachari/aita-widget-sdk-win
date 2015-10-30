using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

// The Templated Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234235

namespace AAWidgetSDK
{

        public sealed class AAWidget :ContentControl
        {
            public AAWidget()
            {
            
            this.DefaultStyleKey = typeof(AAWidget);
                
            }

            public ImageSource PicPath
            {
                get
                {
                    return (ImageSource)GetValue(PicPathProperty);
                }
                set
                {
                    SetValue(PicPathProperty, value);
                }
            }
            private static readonly DependencyProperty PicPathProperty =
        DependencyProperty.Register("PicPath", typeof(ImageSource), typeof(AAWidget), new PropertyMetadata(null));

        }
    
}
