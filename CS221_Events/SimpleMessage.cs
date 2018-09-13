using System;
using System.Activities;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime;
using System.Workflow.ComponentModel.Serialization;
using System.Windows.Forms;

namespace CS221_Events
{
    [ContentProperty("Text")]
    [Designer(typeof(ActivityDesigners.SimpleMessageDesigner))]
    public sealed class SimpleMessage : CodeActivity
    {
        [DefaultValue(null)]
        public string Header
        { 
            get; 
            set; 
        }

        public string Text
        { 
            get; 
            set; 
        }

        public SimpleMessage()
        {
        }

        protected override void CacheMetadata(CodeActivityMetadata metadata)
        {
        }

        protected override void Execute(CodeActivityContext context)
        {
            MessageBox.Show(Text, Header);
            WorkflowExecutionLog.Write(this, Header + ": " + Text);
            WorkflowExecutionLog.Write(this, string.Empty);
        }
    }
}
