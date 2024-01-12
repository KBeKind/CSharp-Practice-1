using System.Reflection.Metadata.Ecma335;

internal class User {
private string name;
private string companyName;
private int age;
public string City {get; set;}

public User() {
    companyName="ABC";
}


public string Name {
    get { return name; }
    set { name = value; }
}

public string CompanyName {
    get { return companyName; }
}

public int Age {
    get { return age; }
    set {
        
        if(value<18)
        throw new ArithmeticException("invalid age");
         age = value; }
}

}