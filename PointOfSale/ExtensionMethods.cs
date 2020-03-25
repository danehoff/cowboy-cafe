/*

* Author: Dane Hoffman

* Edited by: (If you are not the original author like the CowpokeChili class)

* Class name: ExtensionMethods

* Purpose: Represents extension methods to be used by our code.

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace PointOfSale.ExtensionMethods
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Finds the ancestor parent tree being edited
        /// </summary>
        public static T FindAncestor<T>(this DependencyObject element) where T : DependencyObject
        {

            var parent = VisualTreeHelper.GetParent(element);

            if (parent == null)
                return null;

            if (parent is T)
                return parent as T;

            return parent.FindAncestor<T>();

        }

    }
}
