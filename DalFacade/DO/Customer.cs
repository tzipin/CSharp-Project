using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    //מתאר לקוח במועדון לכל לקוח שמורים פרטיו האישיים:
    //,ת"ז שהיא המזהה האישי שלו
    //שם פרטי וכן כתובת ומספר טלפון 

    public record Customer(
        int id,
        string? name,
        string? address,
        string? number_phone)
    {
        public Customer() : this(0,null,null,null)
        {

        }
    }
}
