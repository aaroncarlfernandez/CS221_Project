using System;
using System.Activities;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime;
using System.Windows;
using System.Windows.Forms;
using System.Workflow.ComponentModel.Serialization;

namespace CS221_Events
{
    [Designer(typeof(ActivityDesigners.RandomNumberDesigner))]
    public sealed class RandomNumber : CodeActivity
    {
        [RequiredArgument]
        public OutArgument<Int32> Number
        {
            get;
            set;
        }

        [RequiredArgument]
        public InArgument<Int32> From
        {
            get;
            set;
        }

        [RequiredArgument]
        public InArgument<Int32> To
        {
            get;
            set;
        }

        public RandomNumber()
        {
        }

        protected override void CacheMetadata(CodeActivityMetadata metadata)
        {
            RuntimeArgument runtimeArgument1 = new RuntimeArgument("Number", typeof(Int32), ArgumentDirection.Out);
            metadata.Bind((Argument)this.Number, runtimeArgument1);
            RuntimeArgument runtimeArgument2 = new RuntimeArgument("From", typeof(Int32), ArgumentDirection.In);
            metadata.Bind((Argument)this.From, runtimeArgument2);
            RuntimeArgument runtimeArgument3 = new RuntimeArgument("To", typeof(Int32), ArgumentDirection.In);
            metadata.Bind((Argument)this.To, runtimeArgument3);
            metadata.SetArgumentsCollection(new Collection<RuntimeArgument>()
              {
                runtimeArgument1,
                runtimeArgument2,
                runtimeArgument3,
              });
        }

        protected override void Execute(CodeActivityContext context)
        {
            var random = new Random();
            var from = From.Get((ActivityContext)context);
            var to = To.Get((ActivityContext)context);
            var randomNumber = random.Next(from, to);
            Number.Set(context, randomNumber);
            
            WorkflowExecutionLog.Write(this, "Random number generated: " + randomNumber);
            WorkflowExecutionLog.Write(this, string.Empty);
        }
    }
}
