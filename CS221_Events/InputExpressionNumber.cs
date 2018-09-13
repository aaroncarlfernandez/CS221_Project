using System;
using System.Activities;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime;
using System.Windows;
using System.Windows.Forms;
//using System.Windows.Markup;
using System.Workflow.ComponentModel.Serialization;

namespace CS221_Events
{
    [ContentProperty("Number")]
    [Designer(typeof(ActivityDesigners.InputExpressionNumberDesigner))]
    public sealed class InputExpressionNumber : CodeActivity
    {
        [DefaultValue("Enter the number")]
        public InArgument<string> Inscription
        {
            get;
            set;
        }

        [DefaultValue(0)]
        [RequiredArgument]
        public InOutArgument<Int32> Number
        { 
            get; 
            set; 
        }

        public InputExpressionNumber()
        {
        }

        protected override void CacheMetadata(CodeActivityMetadata metadata)
        {
            RuntimeArgument runtimeArgument1 = new RuntimeArgument("Inscription", typeof(string), ArgumentDirection.In);
            metadata.Bind((Argument)this.Inscription, runtimeArgument1);
            RuntimeArgument runtimeArgument2 = new RuntimeArgument("Number", typeof(Int32), ArgumentDirection.InOut);
            metadata.Bind((Argument)this.Number, runtimeArgument2);
            metadata.SetArgumentsCollection(new Collection<RuntimeArgument>()
              {
                runtimeArgument1,
                runtimeArgument2,
              });
        }

        protected override void Execute(CodeActivityContext context)
        {
            var inputIntForm = new InputIntForm();
            inputIntForm.Number = Number.Get((ActivityContext)context);
            inputIntForm.Message = Inscription.Get((ActivityContext)context);

            string logOutput;
            var res = inputIntForm.ShowDialog();

            if (res == DialogResult.OK)
            {
                Number.Set(context, inputIntForm.Number);
                logOutput = inputIntForm.Message + ": " + inputIntForm.Number;
            }
            else
            {
                logOutput = "Number was not entered";
            }
            WorkflowExecutionLog.Write(this, logOutput);
            WorkflowExecutionLog.Write(this, string.Empty);
        }
    }
}
