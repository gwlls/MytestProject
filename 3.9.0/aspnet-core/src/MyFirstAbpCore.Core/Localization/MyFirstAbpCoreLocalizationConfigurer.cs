using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace MyFirstAbpCore.Localization
{
    public static class MyFirstAbpCoreLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(MyFirstAbpCoreConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(MyFirstAbpCoreLocalizationConfigurer).GetAssembly(),
                        "MyFirstAbpCore.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
