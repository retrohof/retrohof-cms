using Volo.Abp.Features;
using Volo.Abp.Validation.StringValues;

namespace Retrohof.Features
{
    public class ViewComponentFeatureDefinitionProvider : FeatureDefinitionProvider
    {
        public override void Define(IFeatureDefinitionContext context)
        {
            var myGroup = context.AddGroup("ViewComponentFeatures");

            myGroup.AddFeature(
                ViewComponentFeatures.TopNavbarToolbar,
                defaultValue: "true",
                //displayName: "TopNavbarToolbar",
                valueType: new ToggleStringValueType()
            );

            myGroup.AddFeature(
                ViewComponentFeatures.MainNavbar,
                defaultValue: "true",
                //displayName: "MainNavbar",
                valueType: new ToggleStringValueType()
            );

            myGroup.AddFeature(
                ViewComponentFeatures.Slider,
                defaultValue: "true",
                //displayName: "Slider",
                valueType: new ToggleStringValueType()
            );

            myGroup.AddFeature(
                ViewComponentFeatures.Suppliers,
                defaultValue: "true",
                //displayName: "Suppliers",
                valueType: new ToggleStringValueType()
            );

            myGroup.AddFeature(
                ViewComponentFeatures.Footer,
                defaultValue: "true",
                //displayName: "Footer",
                valueType: new ToggleStringValueType()
            );

            myGroup.AddFeature(
                ViewComponentFeatures.Introduction,
                defaultValue: "true",
                //displayName: "Introduction",
                valueType: new ToggleStringValueType()
            );

            myGroup.AddFeature(
                ViewComponentFeatures.AboutUs,
                defaultValue: "true",
                //displayName: "AboutUs",
                valueType: new ToggleStringValueType()
            );

            myGroup.AddFeature(
                ViewComponentFeatures.ChooseUs,
                defaultValue: "true",
                //displayName: "ChooseUs",
                valueType: new ToggleStringValueType()
            );

            myGroup.AddFeature(
                ViewComponentFeatures.RecentPosts,
                defaultValue: "true",
                //displayName: "RecentPosts",
                valueType: new ToggleStringValueType()
            );

            myGroup.AddFeature(
                ViewComponentFeatures.OpeningHours,
                defaultValue: "true",
                //displayName: "OpeningHours",
                valueType: new ToggleStringValueType()
            );

            myGroup.AddFeature(
                ViewComponentFeatures.NewsLetter,
                defaultValue: "true",
                //displayName: "NewsLetter",
                valueType: new ToggleStringValueType()
			);

			myGroup.AddFeature(
				ViewComponentFeatures.Maintenance,
				defaultValue: "true",
				//displayName: "Maintenance",
				valueType: new ToggleStringValueType()
			);
        }
    }
}
