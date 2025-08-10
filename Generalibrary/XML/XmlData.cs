using System.Xml;

namespace Generalibrary
{
    public partial class XmlHelper
    {
        public class XmlData
        {

            public string? Name
                => _node?.Name;

            public Dictionary<string, string>? Attributes
            {
                get
                {
                    if (_node == null || _node.Attributes == null)
                        return null;

                    Dictionary<string, string> attr = new Dictionary<string, string>();

                    foreach (XmlAttribute xattr in _node.Attributes)
                        attr.Add(xattr.Name, xattr.Value);

                    return attr;
                }
            }

            public string? Value
                => _node?.Value;

            private XmlElement? _node;

            public XmlData()
            {

            }

            public XmlData(XmlElement node)
            {
                this._node = node;
            }

            public XmlData? GetXmlData(string name)
            {
                if (_node == null)
                    return null;

                foreach (XmlElement child in _node.ChildNodes)
                {
                    if (string.Equals(name, child.Name))
                        return new XmlData(child);
                }

                return null;
            }
        }
    }
}
