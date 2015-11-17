using Bridge.Html5;
using System;

namespace Bridge.jQuery2
{
    public partial class jQuery
    {
        /// <summary>
        /// Get the value of a style property for the first element in the set of matched elements or set one or more CSS properties for every matched element.
        /// </summary>
        /// <param name="propertyName">A CSS property.</param>
        /// <returns></returns>
        public virtual string Css(string propertyName)
        {
            return null;
        }

        /// <summary>
        /// Get the value of a style property for the first element in the set of matched elements or set one or more CSS properties for every matched element.
        /// </summary>
        /// <param name="propertyNames">An array of one or more CSS properties.</param>
        /// <returns></returns>
        public virtual object Css(string[] propertyNames)
        {
            return null;
        }

        /// <summary>
        /// Set one or more CSS properties for the set of matched elements.
        /// </summary>
        /// <param name="name">A CSS property name.</param>
        /// <param name="value">A value to set for the property.</param>
        /// <returns></returns>
        public virtual jQuery Css(string name, object value)
        {
            return null;
        }

        /// <summary>
        /// Set one or more CSS properties for the set of matched elements.
        /// </summary>
        /// <param name="name">A CSS property name.</param>
        /// <param name="function">A function returning the value to set. this is the current element. Receives the index position of the element in the set and the old value as arguments.</param>
        /// <returns></returns>
        public virtual jQuery Css(string name, Delegate function)
        {
            return null;
        }

        /// <summary>
        /// Set one or more CSS properties for the set of matched elements.
        /// </summary>
        /// <param name="name">A CSS property name.</param>
        /// <param name="function">A function returning the value to set. this is the current element. Receives the index position of the element in the set and the old value as arguments.</param>
        /// <returns></returns>
        public virtual jQuery Css(string name, Func<int, string, int> function)
        {
            return null;
        }

        /// <summary>
        /// Set one or more CSS properties for the set of matched elements.
        /// </summary>
        /// <param name="name">A CSS property name.</param>
        /// <param name="function">A function returning the value to set. this is the current element. Receives the index position of the element in the set and the old value as arguments.</param>
        /// <returns></returns>
        public virtual jQuery Css(string name, Func<int, string, string> function)
        {
            return null;
        }

        /// <summary>
        /// Set one or more CSS properties for the set of matched elements.
        /// </summary>
        /// <param name="properties">An object of property-value pairs to set.</param>
        /// <returns></returns>
        public virtual jQuery Css(object properties)
        {
            return null;
        }

        /// <summary>
        /// Hook directly into jQuery to override how particular CSS properties are retrieved or set, normalize CSS property naming, or create custom properties.
        /// </summary>
        public static readonly CssHooks CssHooks;

        /// <summary>
        /// Get the current coordinates of the first element in the set of matched elements, relative to the document.
        /// </summary>
        /// <returns></returns>
        public virtual Point Offset()
        {
            return null;
        }

        /// <summary>
        /// Set the current coordinates of every element in the set of matched elements, relative to the document.
        /// </summary>
        /// <param name="coordinates">An object containing the properties top and left, which are numbers indicating the new top and left coordinates for the elements.</param>
        /// <returns></returns>
        public virtual jQuery Offset(object coordinates)
        {
            return null;
        }

        /// <summary>
        /// Get the current coordinates of the first element in the set of matched elements, relative to the offset parent.
        /// </summary>
        /// <returns></returns>
        public virtual Point Position()
        {
            return null;
        }

        /// <summary>
        /// Get the current horizontal position of the scroll bar for the first element in the set of matched elements.
        /// </summary>
        /// <returns></returns>
        public virtual int ScrollLeft()
        {
            return 0;
        }

        /// <summary>
        /// Set the current horizontal position of the scroll bar for each of the set of matched elements.
        /// </summary>
        /// <param name="value">An integer indicating the new position to set the scroll bar to.</param>
        /// <returns></returns>
        public virtual jQuery ScrollLeft(int value)
        {
            return null;
        }

        /// <summary>
        ///  Get the current vertical position of the scroll bar for the first element in the set of matched elements or set the vertical position of the scroll bar for every matched element.
        /// </summary>
        /// <returns></returns>
        public virtual int ScrollTop()
        {
            return 0;
        }

        /// <summary>
        /// Set the current vertical position of the scroll bar for each of the set of matched elements.
        /// </summary>
        /// <param name="value">An integer indicating the new position to set the scroll bar to.</param>
        /// <returns></returns>
        public virtual jQuery ScrollTop(int value)
        {
            return null;
        }
    }

    [External]
    [Name("Object")]
    [Constructor("{}")]
    public class CssHook
    {
        public Func<Element, object, object, object> Get;
        public Action<Element, object> Set;
    }

    [External]
    [Name("Object")]
    [Constructor("{}")]
    public class CssHooks
    {
        public new virtual CssHook this[string name]
        {
            get
            {
                return null;
            }
            set
            {
            }
        }
    }

    [External]
    [Name("Object")]
    [Constructor("{}")]
    public class Point
    {
        private Point()
        {
        }

        public readonly int Top;

        public readonly int Left;
    }
}
