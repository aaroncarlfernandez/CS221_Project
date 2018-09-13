using System;
using System.Activities.Presentation.Metadata;
using System.ComponentModel;

namespace CS221_Events.ActivityDesigners
{
    public partial class MessageDesigner
    {
        public MessageDesigner()
        {
            InitializeComponent();
        }

        public static void RegisterMetadata(AttributeTableBuilder builder)
        {
            System.Type type = typeof(Message);
            builder.AddCustomAttributes(type, new DesignerAttribute(typeof(PrintDesigner)));
        }
    }
}