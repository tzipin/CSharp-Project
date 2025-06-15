

using DO;

namespace Dal;

internal static class DataSource

{
    internal static List<Product?> Products = new List<Product?>();
    internal static List<Customer?> Customers = new List<Customer?>();
    internal static List<Sale?> Sales = new List<Sale?>();
    internal static class Config
    {
        internal const int MIN_CODE = 101;
        private static int IndexCode = MIN_CODE;
        internal const int MIN_BARCODE = 1001;
        private static int IndexBarcode = MIN_BARCODE;
        //קוד למבצע
        public static int code
        {
            get { return IndexCode+=7; }
        }
        //קוד למוצרים
        public static int barcode
        {
            get { return IndexBarcode+=3; }
        }
    }
}    
