namespace DO;

[Serializable]
public class DalIdNoFound : Exception
{
    public DalIdNoFound(string e) :base(e) { }
}

[Serializable]
public class DalIdExists : Exception
{
    public DalIdExists(string e) : base(e) { }    
}

[Serializable]
public class DalXmlError : Exception
{
    public DalXmlError(string e) : base(e) { }
}
