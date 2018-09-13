using System;
using System.Activities.Presentation.Metadata;
using System.ComponentModel;

namespace CS221_Events.ActivityDesigners
{
    public partial class ExpressionMessageDesigner
    {
        public ExpressionMessageDesigner()
        {
            InitializeComponent();
        }

        public static void RegisterMetadata(AttributeTableBuilder builder)
        {
            System.Type type = typeof(ExpressionMessage);
            builder.AddCustomAttributes(type, new DesignerAttribute(typeof(ExpressionMessageDesigner)));
        }
    }
}