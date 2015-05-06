﻿using System;
using System.Collections.Generic;

namespace Bridge.jQuery2
{
    public partial class jQuery
    {
        /// <summary>
        /// Adds the specified class(es) to each of the set of matched elements.
        /// </summary>
        /// <param name="className">One or more space-separated classes to be added to the class attribute of each matched element.</param>
        /// <returns></returns>
        public virtual jQuery AddClass(string className)
        {
            return null;
        }

        /// <summary>
        /// Adds the specified class(es) to each of the set of matched elements.
        /// </summary>
        /// <param name="function">A function returning one or more space-separated class names to be added to the existing class name(s). Receives the index position of the element in the set and the existing class name(s) as arguments. Within the function, this refers to the current element in the set.</param>
        /// <returns></returns>
        public virtual jQuery AddClass(Delegate function)
        {
            return null;
        }

        /// <summary>
        /// Adds the specified class(es) to each of the set of matched elements.
        /// </summary>
        /// <param name="function">A function returning one or more space-separated class names to be added to the existing class name(s). Receives the index position of the element in the set and the existing class name(s) as arguments. Within the function, this refers to the current element in the set.</param>
        /// <returns></returns>
        public virtual jQuery AddClass(Func<int, string> function)
        {
            return null;
        }

        /// <summary>
        /// Adds the specified class(es) to each of the set of matched elements.
        /// </summary>
        /// <param name="function">A function returning one or more space-separated class names to be added to the existing class name(s). Receives the index position of the element in the set and the existing class name(s) as arguments. Within the function, this refers to the current element in the set.</param>
        /// <returns></returns>
        public virtual jQuery AddClass(Func<int, string, string> function)
        {
            return null;
        }

        /// <summary>
        /// Get the value of an attribute for the first element in the set of matched elements.
        /// </summary>
        /// <param name="attributeName">The name of the attribute to get.</param>
        /// <returns></returns>
        public virtual string Attr(string attributeName)
        {
            return null;
        }

        /// <summary>
        /// Get the value of an attribute for the first element in the set of matched elements.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="attributeName">The name of the attribute to get.</param>
        /// <returns></returns>
        public virtual T Attr<T>(string attributeName)
        {
            return default(T);
        }

        /// <summary>
        ///  Set one or more attributes for the set of matched elements.
        /// </summary>
        /// <param name="attributeName">The name of the attribute to set.</param>
        /// <param name="value">A value to set for the attribute.</param>
        /// <returns></returns>
        public virtual jQuery Attr(string attributeName, string value)
        {
            return null;
        }

        /// <summary>
        ///  Set one or more attributes for the set of matched elements.
        /// </summary>
        /// <param name="attributeName">The name of the attribute to set.</param>
        /// <param name="value">A value to set for the attribute.</param>
        /// <returns></returns>
        public virtual jQuery Attr(string attributeName, int value)
        {
            return null;
        }

        /// <summary>
        ///  Set one or more attributes for the set of matched elements.
        /// </summary>
        /// <param name="attributes">An object of attribute-value pairs to set.</param>
        /// <returns></returns>
        public virtual jQuery Attr(Dictionary<string, object> attributes)
        {
            return null;
        }

        /// <summary>
        ///  Set one or more attributes for the set of matched elements.
        /// </summary>
        /// <param name="attributes">An object of attribute-value pairs to set.</param>
        /// <returns></returns>
        public virtual jQuery Attr(object attributes)
        {
            return null;
        }

        /// <summary>
        ///  Set one or more attributes for the set of matched elements.
        /// </summary>
        /// <param name="attributeName">The name of the attribute to set.</param>
        /// <param name="function">A function returning the value to set. this is the current element. Receives the index position of the element in the set and the old attribute value as arguments.</param>
        /// <returns></returns>
        public virtual jQuery Attr(string attributeName, Delegate function)
        {
            return null;
        }

        /// <summary>
        ///  Set one or more attributes for the set of matched elements.
        /// </summary>
        /// <param name="attributeName">The name of the attribute to set.</param>
        /// <param name="function">A function returning the value to set. this is the current element. Receives the index position of the element in the set and the old attribute value as arguments.</param>
        /// <returns></returns>
        public virtual jQuery Attr(string attributeName, Func<int, string> function)
        {
            return null;
        }

        /// <summary>
        /// Determine whether any of the matched elements are assigned the given class.
        /// </summary>
        /// <param name="className">The class name to search for.</param>
        /// <returns>boolean</returns>
        public virtual bool HasClass(string className)
        {
            return false;
        }

        /// <summary>
        /// Get the HTML contents of the first element in the set of matched elements or set the HTML contents of every matched element.
        /// </summary>
        /// <returns></returns>
        public virtual string Html()
        {
            return null;
        }

        /// <summary>
        /// Set the HTML contents of each element in the set of matched elements.
        /// </summary>
        /// <param name="htmlString">A string of HTML to set as the content of each matched element.</param>
        /// <returns></returns>
        public virtual jQuery Html(string htmlString)
        {
            return null;
        }

        /// <summary>
        /// Set the HTML contents of each element in the set of matched elements.
        /// </summary>
        /// <param name="function">A function returning the HTML content to set. Receives the index position of the element in the set and the old HTML value as arguments. jQuery empties the element before calling the function; use the oldhtml argument to reference the previous content. Within the function, this refers to the current element in the set.</param>
        /// <returns></returns>
        public virtual jQuery Html(Delegate function)
        {
            return null;
        }

        /// <summary>
        /// Set the HTML contents of each element in the set of matched elements.
        /// </summary>
        /// <param name="function">A function returning the HTML content to set. Receives the index position of the element in the set and the old HTML value as arguments. jQuery empties the element before calling the function; use the oldhtml argument to reference the previous content. Within the function, this refers to the current element in the set.</param>
        /// <returns></returns>
        public virtual jQuery Html(Func<int, string, string> function)
        {
            return null;
        }

        /// <summary>
        /// Get the value of a property for the first element in the set of matched elements.
        /// </summary>
        /// <param name="propertyName">The name of the property to get.</param>
        /// <returns></returns>
        public virtual string Prop(string propertyName)
        {
            return null;
        }

        /// <summary>
        /// Get the value of a property for the first element in the set of matched elements.
        /// </summary>
        /// <param name="propertyName">The name of the property to get.</param>
        /// <returns></returns>
        public virtual T Prop<T>(string propertyName)
        {
            return default(T);
        }

        /// <summary>
        /// Set one or more properties for the set of matched elements.
        /// </summary>
        /// <param name="propertyName">The name of the property to set.</param>
        /// <param name="value">A value to set for the property.</param>
        /// <returns></returns>
        public virtual jQuery Prop(string propertyName, object value)
        {
            return null;
        }

        /// <summary>
        /// Set one or more properties for the set of matched elements.
        /// </summary>
        /// <param name="properties">An object of property-value pairs to set.</param>
        /// <returns></returns>
        public virtual jQuery Prop(Dictionary<string, object> properties)
        {
            return null;
        }

        /// <summary>
        /// Set one or more properties for the set of matched elements.
        /// </summary>
        /// <param name="properties">An object of property-value pairs to set.</param>
        /// <returns></returns>
        public virtual jQuery Prop(object properties)
        {
            return null;
        }

        /// <summary>
        /// Set one or more properties for the set of matched elements.
        /// </summary>
        /// <param name="propertyName">The name of the property to set.</param>
        /// <param name="function">A function returning the value to set. Receives the index position of the element in the set and the old property value as arguments. Within the function, the keyword this refers to the current element.</param>
        /// <returns></returns>
        public virtual jQuery Prop(string propertyName, Delegate function)
        {
            return null;
        }

        /// <summary>
        /// Set one or more properties for the set of matched elements.
        /// </summary>
        /// <param name="propertyName">The name of the property to set.</param>
        /// <param name="function">A function returning the value to set. Receives the index position of the element in the set and the old property value as arguments. Within the function, the keyword this refers to the current element.</param>
        /// <returns></returns>
        public virtual jQuery Prop(string propertyName, Func<int, object, object> function)
        {
            return null;
        }

        /// <summary>
        /// Remove an attribute from each element in the set of matched elements.
        /// </summary>
        /// <param name="attributeName">An attribute to remove; as of version 1.7, it can be a space-separated list of attributes.</param>
        /// <returns></returns>
        public virtual jQuery RemoveAttr(string attributeName)
        {
            return null;
        }

        /// <summary>
        /// Remove a single class, multiple classes, or all classes from each element in the set of matched elements.
        /// </summary>
        /// <param name="className">One or more space-separated classes to be removed from the class attribute of each matched element.</param>
        /// <returns></returns>
        public virtual jQuery RemoveClass(string className)
        {
            return null;
        }

        /// <summary>
        /// Remove a single class, multiple classes, or all classes from each element in the set of matched elements.
        /// </summary>
        /// <param name="function">A function returning one or more space-separated class names to be removed. Receives the index position of the element in the set and the old class value as arguments.</param>
        /// <returns></returns>
        public virtual jQuery RemoveClass(Delegate function)
        {
            return null;
        }

        /// <summary>
        /// Remove a single class, multiple classes, or all classes from each element in the set of matched elements.
        /// </summary>
        /// <param name="function">A function returning one or more space-separated class names to be removed. Receives the index position of the element in the set and the old class value as arguments.</param>
        /// <returns></returns>
        public virtual jQuery RemoveClass(Func<int, string, string> function)
        {
            return null;
        }

        /// <summary>
        /// Remove a property for the set of matched elements.
        /// </summary>
        /// <param name="propertyName">The name of the property to remove.</param>
        /// <returns></returns>
        public virtual jQuery RemoveProp(string propertyName)
        {
            return null;
        }

        /// <summary>
        /// Add or remove one or more classes from each element in the set of matched elements, depending on either the class's presence or the value of the switch argument.
        /// </summary>
        /// <param name="className">One or more class names (separated by spaces) to be toggled for each element in the matched set.</param>
        /// <returns></returns>
        public virtual jQuery ToggleClass(string className)
        {
            return null;
        }

        /// <summary>
        /// Add or remove one or more classes from each element in the set of matched elements, depending on either the class's presence or the value of the switch argument.
        /// </summary>
        /// <param name="className">One or more class names (separated by spaces) to be toggled for each element in the matched set.</param>
        /// <param name="switch">A Boolean (not just truthy/falsy) value to determine whether the class should be added or removed.</param>
        /// <returns></returns>
        public virtual jQuery ToggleClass(string className, bool @switch)
        {
            return null;
        }

        /// <summary>
        /// Add or remove one or more classes from each element in the set of matched elements, depending on either the class's presence or the value of the switch argument.
        /// </summary>
        /// <returns></returns>
        public virtual jQuery ToggleClass()
        {
            return null;
        }

        /// <summary>
        /// Add or remove one or more classes from each element in the set of matched elements, depending on either the class's presence or the value of the switch argument.
        /// </summary>
        /// <param name="switch">A Boolean (not just truthy/falsy) value to determine whether the class should be added or removed.</param>
        /// <returns></returns>
        public virtual jQuery ToggleClass(bool @switch)
        {
            return null;
        }

        /// <summary>
        /// Add or remove one or more classes from each element in the set of matched elements, depending on either the class's presence or the value of the switch argument.
        /// </summary>
        /// <param name="function">A function that returns class names to be toggled in the class attribute of each element in the matched set. Receives the index position of the element in the set, the old class value, and the switch as arguments.</param>
        /// <returns></returns>
        public virtual jQuery ToggleClass(Delegate function)
        {
            return null;
        }

        /// <summary>
        /// Add or remove one or more classes from each element in the set of matched elements, depending on either the class's presence or the value of the switch argument.
        /// </summary>
        /// <param name="function">A function that returns class names to be toggled in the class attribute of each element in the matched set. Receives the index position of the element in the set, the old class value, and the switch as arguments.</param>
        /// <returns></returns>
        public virtual jQuery ToggleClass(Func<int, string, bool, string> function)
        {
            return null;
        }

        /// <summary>
        /// Add or remove one or more classes from each element in the set of matched elements, depending on either the class's presence or the value of the switch argument.
        /// </summary>
        /// <param name="function">A function that returns class names to be toggled in the class attribute of each element in the matched set. Receives the index position of the element in the set, the old class value, and the switch as arguments.</param>
        /// <param name="switch">A Boolean (not just truthy/falsy) value to determine whether the class should be added or removed.</param>
        /// <returns></returns>
        public virtual jQuery ToggleClass(Func<int, string, bool, string> function, bool @switch)
        {
            return null;
        }

        /// <summary>
        /// Get the current value of the first element in the set of matched elements.
        /// </summary>
        /// <returns></returns>
        public virtual string Val()
        {
            return null;
        }

        /// <summary>
        /// Get the current value of the first element in the set of matched elements.
        /// </summary>
        /// <returns></returns>
        public virtual T Val<T>()
        {
            return default(T);
        }

        /// <summary>
        /// Set the value of each element in the set of matched elements.
        /// </summary>
        /// <param name="value">A string of text or an array of strings corresponding to the value of each matched element to set as selected/checked.</param>
        /// <returns></returns>
        public virtual jQuery Val(string value)
        {
            return null;
        }

        /// <summary>
        /// Set the value of each element in the set of matched elements.
        /// </summary>
        /// <param name="value">A string of text or an array of strings corresponding to the value of each matched element to set as selected/checked.</param>
        /// <returns></returns>
        public virtual jQuery Val(string[] value)
        {
            return null;
        }

        /// <summary>
        /// Set the value of each element in the set of matched elements.
        /// </summary>
        /// <param name="function">A function returning the value to set. this is the current element. Receives the index position of the element in the set and the old value as arguments.</param>
        /// <returns></returns>
        public virtual jQuery Value(Delegate function)
        {
            return null;
        }

        /// <summary>
        /// Set the value of each element in the set of matched elements.
        /// </summary>
        /// <param name="function">A function returning the value to set. this is the current element. Receives the index position of the element in the set and the old value as arguments.</param>
        /// <returns></returns>
        public virtual jQuery Value(Func<int, string, string> function)
        {
            return null;
        }
    }
}
