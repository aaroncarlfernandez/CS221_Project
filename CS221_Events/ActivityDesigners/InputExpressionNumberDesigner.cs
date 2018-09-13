using System;
using System.Activities.Presentation.Metadata;
using System.ComponentModel;
using System.Activities.Presentation;

namespace CS221_Events.ActivityDesigners
{
    public partial class InputExpressionNumberDesigner
    {
        public InputExpressionNumberDesigner()
        {
            InitializeComponent();
        }

        public static void RegisterMetadata(AttributeTableBuilder builder)
        {
            System.Type type = typeof(InputExpressionNumber);
            builder.AddCustomAttributes(type, new DesignerAttribute(typeof(InputExpressionNumberDesigner)));
        }
    }
}