using System;
using System.Activities.Presentation.Metadata;
using System.ComponentModel;
using System.Activities.Presentation;

namespace CS221_Events.ActivityDesigners
{
    public partial class RandomNumberDesigner
    {
        public RandomNumberDesigner()
        {
            InitializeComponent();
        }

        public static void RegisterMetadata(AttributeTableBuilder builder)
        {
            System.Type type = typeof(RandomNumber);
            builder.AddCustomAttributes(type, new DesignerAttribute(typeof(RandomNumberDesigner)));
            //builder.AddCustomAttributes(type, new ActivityDesignerOptionsAttribute { AlwaysCollapseChildren = true, AllowDrillIn = false });
            builder.AddCustomAttributes(type, type.GetProperty("DisplayName"), BrowsableAttribute.No);
        }
    }
}