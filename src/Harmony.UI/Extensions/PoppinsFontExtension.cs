using System;
using System.Windows.Markup;
using System.Windows.Media;

namespace Harmony.UI.Extensions
{
    [MarkupExtensionReturnType(typeof(FontFamily))]
    public class PoppinsFontExtension : MarkupExtension
    {
        private static readonly Lazy<FontFamily> _poppins = 
            new(() => new FontFamily(new Uri("pack://application:,,,/Harmony.UI;component/Resources/Poppins/"), "./#Poppins"));

        public override object ProvideValue(IServiceProvider serviceProvider) => _poppins.Value;
    }
}
