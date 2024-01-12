internal partial class Employee {

    public int EmpId;
    public string? EmpName;

    public Employee(){
        this.EmpId = 1;
        this.EmpName = "John";
    }
    
    public partial void DisplayDetails();

}