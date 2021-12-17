class User
{
    public bool wq;
    string name;
    int age;

    public User(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public string Name
    {
        get{return name;}
    }
    public int Age
    {
        get{return age;}
    }
}