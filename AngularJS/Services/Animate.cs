﻿using Bridge.AngularJS.Services;
using Bridge.Html5;
using System;

namespace Bridge.AngularJS
{
    public class Animate
    {
        /// <summary>
        /// Event Phase (Start or Close)
        /// </summary>
        [Enum(Emit.StringNameLowerCase)]
        public enum Phase { Start, Close }

        /// <summary>
        /// Sets up an event listener to fire whenever the animation event
        /// (enter, leave, move, etc...) has fired on the given element or among
        /// any of its children.
        /// </summary>
        /// <param name="eventName">
        /// The animation event that will be captured (e.g. enter, leave, move,
        /// addClass, removeClass, etc...).
        /// </param>
        /// <param name="container">
        /// The container element that will capture each of the animation events
        /// that are fired on itself as well as among its children.
        /// </param>
        /// <param name="callback">
        /// Callback. Once the listener is fired, the provided callback is fired
        /// with the params: Element (HTML DOM Element) and phase which can be
        /// either 'start' or 'close'.
        /// </param>
        public void On(string eventName, Element container,
            Action<Element, Phase> callback)
        {
            return;
        }

        /// <summary>
        /// Deregisters an event listener based on the event which has been
        /// associated with the provided element.
        /// </summary>
        /// <param name="eventName">
        /// The animation event (e.g. enter, leave, move, addClass, removeClass,
        /// etc...).
        /// </param>
        /// <param name="container">
        /// The container element the event listener was placed on.
        /// </param>
        /// <param name="callback">Callback.</param>
        public void Off(string eventName, Element container = default(Element),
            Action callback = default(Action))
        {
            return;
        }

        /// <summary>
        /// Associates the provided element with a host parent element to allow
        /// the element to be animated even if it exists outside of the DOM
        /// structure of the Angular application. By doing so, any animation
        /// triggered via $animate can be issued on the element despite being
        /// outside the realm of the application or within another application.
        /// </summary>
        /// <param name="childElement">
        /// The external element that will be pinned.
        /// </param>
        /// <param name="parentElement">
        /// The host parent element that will be associated with the external
        /// element.
        /// </param>
        public void Pin(Element childElement, Element parentElement)
        {
            return;
        }

        /// <summary>
        /// Used to get and set whether animations are enabled or not on the
        /// entire application or on an element and its children.
        /// </summary>
        /// <param name="element">
        /// The element that will be considered for checking/setting the enabled
        /// state.
        /// </param>
        /// <param name="enabled">
        /// Whether or not the animations will be enabled for the element.
        /// </param>
        /// <returns>Whether or not animations are enabled.</returns>
        public bool Enabled(Element element = default(Element), 
            bool enabled = default(bool))
        {
            return default(bool);
        }

        /// <summary>
        /// Cancels the provided animation.
        /// </summary>
        /// <param name="animationPromise">
        /// The animation promise that is returned when an animation is started.
        /// </param>
        /// <typeparam name="T">The underlying promise type.</typeparam>
        public void Cancel<T>(Promise<T> animationPromise) {
            return;
        }

        /// <summary>
        /// Inserts the element into the DOM either after the <c>after</c>
        /// element (if provided) or as the first child within the parent
        /// element and then triggers an animation. A promise is returned that
        /// will be resolved during the next digest once the animation has
        /// completed.
        /// </summary>
        /// <param name="element">
        /// The element which will be inserted into the DOM.
        /// </param>
        /// <param name="parent">
        /// The parent element which will append the element as a child (so long
        /// as the after element is not present).
        /// </param>
        /// <param name="after">
        /// The sibling element after which the element will be appended.
        /// </param>
        /// <param name="options">
        /// An optional collection of options/styles that will be applied to the
        /// element.
        /// </param>
        /// <typeparam name="T">The underlying promise type.</typeparam>
        /// <returns>The animation callback promise.</returns>
        public Promise<T> Enter<T>(Element element, Element parent,
            Element after = default(Element), object options = default(object))
        {
            return default(Promise<T>);
        }

        /// <summary>
        /// Inserts (moves) the element into its new position in the DOM either
        /// after the after element (if provided) or as the first child within
        /// the parent element and then triggers an animation. A promise is
        /// returned that will be resolved during the next digest once the
        /// animation has completed.
        /// </summary>
        /// <param name="element">
        /// The element which will be moved into the new DOM position.
        /// </param>
        /// <param name="parent">
        /// The parent element which will append the element as a child (so long
        /// as the after element is not present).
        /// </param>
        /// <param name="after">
        /// The sibling element after which the element will be appended.
        /// </param>
        /// <param name="options">
        /// An optional collection of options/styles that will be applied to the
        /// element.
        /// </param>
        /// <typeparam name="T">The underlying promise type.</typeparam>
        /// <returns>The animation callback promise.</returns>
        public Promise<T> Move<T>(Element element, Element parent,
            Element after = default(Element),
            object options = default(object))
        {
            return default(Promise<T>);
        }

        /// <summary>
        /// Triggers an animation and then removes the element from the DOM.
        /// When the function is called a promise is returned that will be
        /// resolved during the next digest once the animation has completed.
        /// </summary>
        /// <param name="element">
        /// The element which will be removed from the DOM.
        /// </param>
        /// <param name="options">
        /// An optional collection of options/styles that will be applied to the
        /// element.
        /// </param>
        /// <typeparam name="T">The underlying promise type.</typeparam>
        /// <returns>The animation callback promise.</returns>
        public Promise<T> Leave<T>(Element element,
            object options = default(object))
        {
            return default(Promise<T>);
        }

        /// <summary>
        /// Triggers an addClass animation surrounding the addition of the
        /// provided CSS class(es). Upon execution, the addClass operation will
        /// only be handled after the next digest and it will not trigger an
        /// animation if element already contains the CSS class or if the class
        /// is removed at a later step. Note that class-based animations are
        /// treated differently compared to structural animations (like enter,
        /// move and leave) since the CSS classes may be added/removed at
        /// different points depending if CSS or JavaScript animations are used.
        /// </summary>
        /// <returns>The animation callback promise.</returns>
        /// <param name="element">
        /// The element which the CSS classes will be applied to.
        /// </param>
        /// <param name="className">
        /// The CSS class(es) that will be removed (multiple classes are
        /// separated via spaces).
        /// </param>
        /// <param name="options">
        /// An optional collection of options/styles that will be applied to the
        /// element.
        /// </param>
        /// <typeparam name="T">The underlying promise type.</typeparam>
        public Promise<T> AddClass<T>(Element element, string className,
            object options = default(object))
        {
            return default(Promise<T>);
        }

        /// <summary>
        /// Performs both the addition and removal of a CSS classes on an
        /// element and (during the process) triggers an animation surrounding
        /// the class addition/removal. Much like <c>$animate.addClass</c> and
        /// <c>$animate.removeClass</c>, setClass will only evaluate the classes
        /// being added/removed once a digest has passed. Note that class-based
        /// animations are treated differently compared to structural animations
        /// (like enter, move and leave) since the CSS classes may be
        /// added/removed at different points depending if CSS or JavaScript
        /// animations are used.
        /// </summary>
        /// <returns>The animation callback promise.</returns>
        /// <param name="element">
        /// The element which the CSS classes will be applied to.
        /// </param>
        /// <param name="add">
        /// The CSS class(es) that will be added (multiple classes are separated
        /// via spaces).
        /// </param>
        /// <param name="remove">
        /// The CSS class(es) that will be removed (multiple classes are
        /// separated via spaces).
        /// </param>
        /// <param name="options">
        /// An optional collection of options/styles that will be applied to the
        /// element.
        /// </param>
        /// <typeparam name="T">The animation callback promise.</typeparam>
        public Promise<T> SetClass<T>(Element element, string add,
            string remove, object options = default(object))
        {
            return default(Promise<T>);
        }

        /// <summary>
        /// Performs an inline animation on the element which applies the
        /// provided to and from CSS styles to the element. If any detected CSS
        /// transition, keyframe or JavaScript matches the provided className
        /// value then the animation will take on the provided styles.
        /// </summary>
        /// <returns>The animation callback promise.</returns>
        /// <param name="element">
        /// The element which the CSS styles will be applied to.
        /// </param>
        /// <param name="from">
        /// The from (starting) CSS styles that will be applied to the element
        /// and across the animation.
        /// </param>
        /// <param name="to">
        /// The to (destination) CSS styles that will be applied to the element
        /// and across the animation.
        /// </param>
        /// <param name="className">
        /// An optional CSS class that will be applied to the element for the
        /// duration of the animation. If this value is left as empty then a CSS
        /// class of <c>ng-inline-animate</c> will be applied to the element.
        /// </param>
        /// <param name="options">Options.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        /// <remarks>
        /// This is output as JavaScript 'animate()' call.
        /// If no animation is detected then this value will not be appplied to
        /// the element.
        /// </remarks>
        [Name("animate")]
        public Promise<T> AnimateIt<T>(Element element, object from, object to,
            string className = default(string),
            object options = default(object))
        {
            return default(Promise<T>);
        }
    }
}

