namespace DO;
// מתאר מוצר בחנות לכל מוצר שמורים הפרטים הבאים:
//BARCODE ברקוד המוצר-המזהה 
//שם המוצר,הקטגוריה- מתוך מערך הקטגוריות 
//מחיר המוצר והכמות של המוצר במלאי 
public record Product(
    int barcode,
    string? name = null,
    category? category = null,
    double? price = null,
    int? amount = null
    )
{
    public Product() : this(0,null,null,null,null)
    {

    }
}
