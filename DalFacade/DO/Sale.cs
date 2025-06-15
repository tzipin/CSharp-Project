

namespace DO;


//מתאר מבצע בחנות:
//CODE,לכל מבצע יש קוד מזהה יחודי רץ
//וכן ברקוד המוצר שעליו המבצע חל,
//כמות שמזכה במבצע,המחיר לכמות זו במבצע,
//למי מיועד המבצע? לכלל הלקוחות או ללקוחות מועדון בלבד
//וכן תקופת המבצע
public record Sale(
    int code,
    int barcode,
    int? amount,
    double? price,
    bool? isClub,
    DateTime? startDate,
    DateTime? endDate)
{
    public Sale():this(0,0,null,null,null,null,null) { }
}
