using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace RibbonMenuMerging
{
    /// <summary>
    ///  Represents the valueconverters.
    /// </summary>
    public class BooltoSizeformConverter : IValueConverter
    {
        #region BooltoSizeformConverter
        /// <summary>
        /// Method which is used to set the size.
        /// </summary>
        /// <param name="value">Value inwhich size to be convert.</param>
        /// <param name="targetType">Bool type</param>
        /// <param name="parameter">Parmeter to be passed.</param>
        /// <param name="culture">Culture </param>
        /// <returns>Returns size</returns>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value.Equals(true))
            {
                return "Large";
            }
            else
            {
                return "Small";
            }
        }

        /// <summary>
        /// Method which is used to set back the size.
        /// </summary>
        /// <param name="value">Value inwhich size to be convert back.</param>
        /// <param name="targetType">Bool type</param>
        /// <param name="parameter">Parmeter to be passed.</param>
        /// <param name="culture">Culture</param>
        /// <returns>Returns size</returns>
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
    public class ItemDataTemplateSelector : DataTemplateSelector
    {
        #region ItemDataTemplateSelector

        /// <summary>
        /// Method which is used to select the template.
        /// </summary>
        /// <param name="item">Template to be changed.</param>
        /// <param name="container">Control container.</param>
        /// <returns></returns>
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement element = container as FrameworkElement;
            if (element != null && item != null)
            {
                 if(item is CustomRibbonItem && (item as CustomRibbonItem).IsCheckBox)
                {
                    return element.FindResource("RibbonCheckBox") as DataTemplate;
                }
                else
                {
                    return element.FindResource("Ribbonbutton") as DataTemplate;
                }
            }
            return null;
        }
        #endregion
    }
    public class ImageConverter : IValueConverter
    {
        #region ImageConverter
        /// <summary>
        /// Method which is used to convert the images to string format.
        /// </summary>
        /// <param name="value">Value inwhich size to be convert.</param>
        /// <param name="targetType">String type.</param>
        /// <param name="parameter">Image.</param>
        /// <param name="culture">Culture.</param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null)
            {
                string str = value.ToString();
                return "../Images/" + str;
            }
            else
            {
                return value;
            }
        }

        /// <summary>
        /// Method which is used to convert back the images to string format.
        /// </summary>
        /// <param name="value">Value inwhich size to be convert back.</param>
        /// <param name="targetType">String type.</param>
        /// <param name="parameter">Image.</param>
        /// <param name="culture">Culture.</param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}
