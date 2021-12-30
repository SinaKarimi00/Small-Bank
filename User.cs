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
        get{return name;}
    }
    public int Age
    {
        get{return age;}
    }
    public int Pass
    {
        get{return pass;}
    }
}