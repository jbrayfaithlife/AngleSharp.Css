#nullable enable
namespace AngleSharp.Css.RenderTree
{
    using AngleSharp.Css.Dom;
    using AngleSharp.Dom;
    using System.Collections.Generic;

    class ElementRenderNode : IRenderElement
    {
        public ElementRenderNode(IElement reference, IEnumerable<IRenderNode> children, ICssStyleDeclaration specifiedStyle, ICssStyleDeclaration computedStyle)
        {
            Ref = reference;
            Children = children;
            SpecifiedStyle = specifiedStyle;
            ComputedStyle = computedStyle;
        }

        public IElement Ref { get; }

        INode IRenderNode.Ref => Ref;

        public IEnumerable<IRenderNode> Children { get; }

        public ICssStyleDeclaration SpecifiedStyle { get; }

        public ICssStyleDeclaration ComputedStyle { get; }
    }
}
