﻿namespace Generalibrary
{
    public class XmlNameAttribute : Attribute
    {
        public string Name { get; set; }

        public XmlNameAttribute(string name)
            => Name = name;
    }
}
