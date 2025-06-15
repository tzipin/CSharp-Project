using DO;

namespace BO;

[Serializable]
public class BlIdNoFound : Exception
{
    public BlIdNoFound(string e) : base(e) { }
    public BlIdNoFound(string e, DalIdNoFound inner) : base(e, inner) { }
}

[Serializable]
public class BlIdExists : Exception
{
    public BlIdExists(string e) : base (e) { }
    public BlIdExists(string e, DalIdExists inner) : base(e, inner) { }
}

[Serializable]
public class BlInvalidInput : Exception
{
    public BlInvalidInput(string e) : base(e) { }    
}

[Serializable]
public class BlOutOfStock : Exception
{
    public BlOutOfStock(string e) : base(e) { }
}

[Serializable]
public class BlXmlError : Exception
{
    public BlXmlError(string e) : base(e) { }
    public BlXmlError(string e, DalXmlError inner) : base(e, inner) { }  
}

[Serializable]
public class BlNegativeQuantity : Exception
{
    public BlNegativeQuantity(string e) : base(e) { }
}

