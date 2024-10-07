public class Dataset : ICloneable {

    public string Name{get; private set;}
    private Dictionary<string, Curve> CurvesByName{get; private set;}
    public Dataset(Dictionary<string, Curve> curvesByName) {
        CurvesByName = curvesList;
    }

    public Curve getByName(string name) {
        if (CurvesByName.ContainsKey(name)) {
            return CurvesByName[name];
        }

        return null;
    }

    public Curve this[string namecurve]{
        get{
            return null;
        }
        set{
            if (CurvesByName.ContainsKey(namecurve)) {
                CurvesByName[namecurve] = value
            }
        }
    }

    public Curve this[int i]{
        get{
            return null;
        }
        set{
            return CurvesByName.Count = i
        }
    }

    public int Count{
        get{
            return CurvesByName.Count;
        }
    }

    public object Clone() {return new Dataset(CurvesByName);}

    public override bool Equals(object obj)
    {
        //
        // See the full list of guidelines at
        //   http://go.microsoft.com/fwlink/?LinkID=85237
        // and also the guidance for operator== at
        //   http://go.microsoft.com/fwlink/?LinkId=85238
        //
        
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        
        // TODO: write your implementation of Equals() here
        throw new System.NotImplementedException();
        return base.Equals (obj);
    }
}