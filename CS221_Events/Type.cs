using System;
using System.Activities;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime;
//using System.Windows.Markup;
using System.Workflow.ComponentModel.Serialization;

namespace CS221_Events
{
    [ContentProperty("Type")]
    [Designer(typeof(ActivityDesigners.PrintDesigner))]
    public sealed class Type : CodeActivity
    {
        [DefaultValue(null)]
        public InArgument<object> Print
        { 
            get; 
            set; 
        }

        public bool Line_translation
        {
            get;
            set;
        }

        public Type()
        {
        }

        protected override void CacheMetadata(CodeActivityMetadata metadata)
        {
            RuntimeArgument runtimeArgument1 = new RuntimeArgument("Print", typeof(object), ArgumentDirection.In);
            metadata.Bind((Argument)this.Print, runtimeArgument1);
            metadata.SetArgumentsCollection(new Collection<RuntimeArgument>()
              {
                runtimeArgument1,
              });
        }

        protected override void Execute(CodeActivityContext context)
        {
            var text = Print.Get((ActivityContext)context).ToString();

            if (Line_translation)
                WorkflowExecutionLog.Write(this, text);
            else
                WorkflowExecutionLog.Write(this, text);

            WorkflowExecutionLog.Write(this, string.Empty);
        }
    }
}
