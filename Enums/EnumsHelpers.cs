using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CRFR_Automation_SpecFlow.Enums
{
    public enum SelectorType
    {
        Id = 0,
        Css = 1,
        Name = 2,
        XPath = 3,
        ClassName = 4,
        LinkText = 5
    }

    public enum AttributeType
    {
        [Description("Id")]
        Id,
        [Description("ClassName")]
        ClassName,
        [Description("disabled")]
        StatusElement,
        [Description("Tag")]
        Tag,
        [Description("Node")]
        Node
    }

    public enum StatusElement
    {
        Enabled = 0,
        Disabled = 1,
    }

}
