
using System.Xml.Linq;

namespace Dal;

internal static class Config
{
    private const string INDEX_CODE = "IndexCode";
    private const string INDEX_BARCODE = "IndexBarcode";

    private static string fileConfigName = @"..\xml\data-config.xml";
    public static int indexCode { 
        get 
        {
            XElement xml = XElement.Load(fileConfigName);
            int index = (int) xml.Element(INDEX_CODE);
            xml.Element(INDEX_CODE).Value = (index += 7).ToString();
            xml.Save(fileConfigName);
            return index;
        }
    }
    public static int indexBarcode
    {
        get
        {
            XElement xml = XElement.Load(fileConfigName);
            int index = (int)xml.Element(INDEX_BARCODE);
            xml.Element(INDEX_BARCODE).Value = (index += 3).ToString();
            xml.Save(fileConfigName);
            return index;
        }
    }
}
