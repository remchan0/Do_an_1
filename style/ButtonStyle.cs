using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Do_An_1.style
{
    public class ButtonStyle : Style
    {
        public static readonly DependencyProperty IconSourceProperty =
            DependencyProperty.RegisterAttached("IconSource", typeof(string), typeof(ButtonStyle), new PropertyMetadata(null));

        public static void SetIconSource(UIElement element, string value)
        {
            element.SetValue(IconSourceProperty, value);
        }

        public static string GetIconSource(UIElement element)
        {
            return (string)element.GetValue(IconSourceProperty);
        }
    }
    public static class IsSelectedStyle
    {
        // Tạo AttachedProperty cho IsSelected
        public static readonly DependencyProperty IsSelectedProperty =
            DependencyProperty.RegisterAttached("IsSelected", typeof(bool), typeof(IsSelectedStyle), new PropertyMetadata(false));

        // Getter và Setter cho IsSelected
        public static void SetIsSelected(UIElement element, bool value)
        {
            element.SetValue(IsSelectedProperty, value);
        }

        public static bool GetIsSelected(UIElement element)
        {
            return (bool)element.GetValue(IsSelectedProperty);
        }
    }
}
