using System;
using System.Activities.Presentation.Metadata;
using System.ComponentModel;

namespace CS221_Events.ActivityDesigners
{
    public partial class PrintDesigner
    {
        public PrintDesigner()
        {
            InitializeComponent();
        }

        public static void RegisterMetadata(AttributeTableBuilder builder)
        {
            System.Type type = typeof(Type);
            builder.AddCustomAttributes(type, new DesignerAttribute(typeof(PrintDesigner)));
            //builder.AddCustomAttributes(type, type.GetProperty("To"), BrowsableAttribute.No);
            //builder.AddCustomAttributes(type, type.GetProperty("From"), BrowsableAttribute.No);
            //builder.AddCustomAttributes(type, type.GetProperty("Subject"), BrowsableAttribute.No);
            //builder.AddCustomAttributes(type, type.GetProperty("Host"), BrowsableAttribute.No);
        }
    }
}