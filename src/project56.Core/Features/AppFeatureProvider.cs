using Abp.Application.Features;
using Abp.Localization;
using Abp.Runtime.Validation;
using Abp.UI.Inputs;

namespace project56.Features
{
    /* This feature provider is just for an example.
     * You can freely delete all features and add your own.
     */
    public class AppFeatureProvider : FeatureProvider
    {
        public override void SetFeatures(IFeatureDefinitionContext context)
        {
            context.Create(
                AppFeatures.MaxUserCount,
                defaultValue: "0", //0 = unlimited
                displayName: L("MaximumUserCount"),
                inputType: new SingleLineStringInputType(new NumericValueValidator(0, int.MaxValue))
            );

            var chatFeature = context.Create(
                  AppFeatures.ChatFeature,
                  defaultValue: "false",
                  displayName: L("ChatFeature"),
                  inputType: new CheckboxInputType()
                  );

            chatFeature.CreateChildFeature(
                AppFeatures.TenantToTenantChatFeature,
                defaultValue: "false",
                displayName: L("TenantToTenantChatFeature"),
                inputType: new CheckboxInputType()
                );

            chatFeature.CreateChildFeature(
                AppFeatures.TenantToHostChatFeature,
                defaultValue: "false",
                displayName: L("TenantToHostChatFeature"),
                inputType: new CheckboxInputType()
                );

            var sampleBooleanFeature = context.Create(
            AppFeatures.SampleBooleanFeature,
            defaultValue: "false",
            displayName: L("Sample boolean feature"),
            inputType: new CheckboxInputType()
            );

            sampleBooleanFeature.CreateChildFeature(
                AppFeatures.SampleNumericFeature,
                defaultValue: "10",
                displayName: L("Sample numeric feature"),
                inputType: new SingleLineStringInputType(new NumericValueValidator(1, 1000000))
                );

            context.Create(
                AppFeatures.SampleSelectionFeature,
                defaultValue: "B",
                displayName: L("Sample selection feature"),
                inputType: new ComboboxInputType(
                    new StaticLocalizableComboboxItemSource(
                        new LocalizableComboboxItem("A", L("Selection A")),
                        new LocalizableComboboxItem("B", L("Selection B")),
                        new LocalizableComboboxItem("C", L("Selection C"))
                        )
                    )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, project56Consts.LocalizationSourceName);
        }
    }
}
