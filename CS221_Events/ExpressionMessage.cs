using System;
using System.Activities;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime;
//using System.Windows.Markup;
using System.Workflow.ComponentModel.Serialization;
using System.Windows.Forms;

namespace CS221_Events
{
    [ContentProperty("Text")]
    [Designer(typeof(ActivityDesigners.ExpressionMessageDesigner))]
    public sealed class ExpressionMessage : CodeActivity
    {
        [DefaultValue(null)]
        public InArgument<object> Header
        { 
            get; 
            set; 
        }

        public InArgument<object> Text
        { 
            get; 
            set; 
        }

        public ExpressionMessage()
        {
        }

        protected override void CacheMetadata(CodeActivityMetadata metadata)
        {
            RuntimeArgument runtimeArgument1 = new RuntimeArgument("Header", typeof(object), ArgumentDirection.In);
            metadata.Bind((Argument)this.Header, runtimeArgument1);
            RuntimeArgument runtimeArgument2 = new RuntimeArgument("Text", typeof(object), ArgumentDirection.In);
            metadata.Bind((Argument)this.Text, runtimeArgument2);
            metadata.SetArgumentsCollection(new Collection<RuntimeArgument>()
              {
                runtimeArgument1,
                runtimeArgument2
              });
        }

        protected override void Execute(CodeActivityContext context)
        {
            var caption = Header.Get((ActivityContext)context).ToString();
            var text = Text.Get((ActivityContext)context).ToString();
            MessageBox.Show(text, caption);
            WorkflowExecutionLog.Write(this, caption + ": " + text);
            WorkflowExecutionLog.Write(this, string.Empty);
        }
    }
}
