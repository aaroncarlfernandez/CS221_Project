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
    [Designer(typeof(ActivityDesigners.InputNumberDesigner))]
    public sealed class InputNumber : CodeActivity
    {
        public string Inscription
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

        public InputNumber()
        {
        }

        protected override void CacheMetadata(CodeActivityMetadata metadata)
        {
            RuntimeArgument runtimeArgument1 = new RuntimeArgument("Number", typeof(Int32), ArgumentDirection.InOut);
            metadata.Bind((Argument)this.Number, runtimeArgument1);
            metadata.SetArgumentsCollection(new Collection<RuntimeArgument>()
              {
                runtimeArgument1,
              });
        }

        protected override void Execute(CodeActivityContext context)
        {
            var inputIntForm = new InputIntForm();
            inputIntForm.Number = Number.Get((ActivityContext)context);
            inputIntForm.Message = Inscription;
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
