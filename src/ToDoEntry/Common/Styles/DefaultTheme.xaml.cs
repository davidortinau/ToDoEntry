using Xamarin.Forms;

[assembly: ExportFont("fa-solid-900.ttf", Alias = "FontAwesome")]
[assembly: ExportFont("FabMDL2.ttf", Alias = "Fabric")]
[assembly: ExportFont("DMSans-Regular.ttf", Alias = "DMSans")]
[assembly: ExportFont("DMSans-Bold.ttf", Alias = "DMSansBold")]
namespace Common.Styles
{
    public partial class DefaultTheme : ResourceDictionary
    {
        public DefaultTheme()
        {
            InitializeComponent();
        }
    }
}