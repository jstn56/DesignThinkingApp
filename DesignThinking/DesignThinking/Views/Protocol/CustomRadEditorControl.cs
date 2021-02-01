using System;
using System.Collections.Generic;
using System.Text;
using Telerik.XamarinForms.ImageEditor;

namespace DesignThinking.Views.Protocol
{
    public class CustomRadEditorControl : RadImageEditor
    {
        public byte[] SourceAsByteArray { get; set; }
    }
}
