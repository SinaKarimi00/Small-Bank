class User
{
    public bool wq;
    string name;
    int age, pass;

    public User(string name, int age, int pass)
    {
        this.name = name;
        this.age = age;
        this.pass = pass;
    }
    public string Name
    {
        set {name = value;}
        get{return name;}
    }
    public int Age
    {
        set {age = value;}
        get{return age;}
    }
    public int Pass
    {
        set {pass = value;}
        get{return pass;}
    }
}