﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using AngleSharp.DOM.Css;

namespace AngleSharp.DOM.Collections
{
    /// <summary>
    /// A collection of CSS elements.
    /// </summary>
    public class StyleSheetList : DOMCollection, IEnumerable<StyleSheet>
    {
        #region Members

        List<StyleSheet> styleSheets;

        #endregion

        #region ctor

        /// <summary>
        /// Creates a new stylesheet class.
        /// </summary>
        public StyleSheetList()
        {
            styleSheets = new List<StyleSheet>();
        }

        #endregion

        #region Index

        /// <summary>
        /// Gets the stylesheet at the specified index.
        /// If index is greater than or equal to the number
        /// of style sheets in the list, this returns null.
        /// </summary>
        /// <param name="index">The index of the element.</param>
        /// <returns>The stylesheet.</returns>
        public StyleSheet this[int index]
        {
            get
            {
                if (index < 0 || index >= styleSheets.Count)
                    return null;

                return styleSheets[index];
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the number of elements in the list of stylesheets.
        /// </summary>
        public int Length
        {
            get { return styleSheets.Count; }
        }

        #endregion

        #region Internal methods

        /// <summary>
        /// Adds a stylesheet to the list.
        /// </summary>
        /// <param name="styleSheet">The stylesheet to consider.</param>
        internal void Add(StyleSheet styleSheet)
        {
            styleSheets.Add(styleSheet);
        }

        /// <summary>
        /// Removes a stylesheet from the list.
        /// </summary>
        /// <param name="styleSheet">The stylesheet to remove.</param>
        internal void Remove(StyleSheet styleSheet)
        {
            styleSheets.Remove(styleSheet);
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Returns an enumerator that iterates through the stylesheets.
        /// </summary>
        /// <returns>The enumerator.</returns>
        public IEnumerator<StyleSheet> GetEnumerator()
        {
            return styleSheets.GetEnumerator();
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>The enumerator.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)styleSheets).GetEnumerator();
        }

        #endregion

        #region String representation

        /// <summary>
        /// Returns an HTML-code representation of the list of stylesheets.
        /// </summary>
        /// <returns>There is no HTML code to return.</returns>
        public override string ToHtml()
        {
            return string.Empty;
        }

        #endregion
    }
}
