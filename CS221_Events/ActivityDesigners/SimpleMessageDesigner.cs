using System;
using System.Activities.Presentation.Metadata;
using System.ComponentModel;

namespace CS221_Events.ActivityDesigners
{
    public partial class SimpleMessageDesigner
    {
        public SimpleMessageDesigner()
        {
            InitializeComponent();
        }

        public static void RegisterMetadata(AttributeTableBuilder builder)
        {
            System.Type type = typeof(SimpleMessage);
            builder.AddCustomAttributes(type, new DesignerAttribute(typeof(SimpleMessageDesigner)));
        }
    }
}