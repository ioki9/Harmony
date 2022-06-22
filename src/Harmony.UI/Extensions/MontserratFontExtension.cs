using System;
using System.Windows.Markup;
using System.Windows.Media;

namespace Harmony.UI.Extensions
{
    [MarkupExtensionReturnType(typeof(FontFamily))]
    public class MontserratFontExtension : MarkupExtension
    {
        private static readonly Lazy<FontFamily> _montserrat =
            new(() => new FontFamily(new Uri("pack://application:,,,/Harmony.UI;component/Resources/Montserrat/"), "./#Montserrat"));

        public override object ProvideValue(IServiceProvider serviceProvider) => _montserrat.Value;
    }
}
