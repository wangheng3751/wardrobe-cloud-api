using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace WardrobeCloud.Localization
{
    public static class WardrobeCloudLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(WardrobeCloudConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(WardrobeCloudLocalizationConfigurer).GetAssembly(),
                        "WardrobeCloud.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
