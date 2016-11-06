﻿namespace AngleSharp.Svg.Dom
{
    using AngleSharp.Dom;
    using AngleSharp.Extensions;
    using System;

    /// <summary>
    /// Represents an element of the SVG DOM.
    /// </summary>
    class SvgElement : Element, ISvgElement
    {
        #region ctor

        static SvgElement()
        {
            RegisterCallback<SvgElement>(AttributeNames.Style, (element, value) => element.UpdateStyle(value));
        }

        public SvgElement(Document owner, String name, String prefix = null, NodeFlags flags = NodeFlags.None)
            : base(owner, name, prefix, NamespaceNames.SvgUri, flags | NodeFlags.SvgMember)
        {
        }

        #endregion

        #region Methods

        public override INode Clone(Boolean deep = true)
        {
            var factory = Owner.Options.GetFactory<IElementFactory<SvgElement>>();
            var node = factory.Create(Owner, LocalName, Prefix);
            CloneElement(node, deep);
            return node;
        }

        #endregion

        #region Internal Methods

        internal override void SetupElement()
        {
            base.SetupElement();

            var style = this.GetOwnAttribute(AttributeNames.Style);

            if (style != null)
            {
                UpdateStyle(style);
            }
        }

        #endregion
    }
}
