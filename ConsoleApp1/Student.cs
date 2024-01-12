
internal class Student {

    int studentId;
    string studentName;

    public Student() {
    this.studentId = 0;
    this.studentName = "no name";
    }
    public Student(int id, string name){
        this.studentId = id;
        this.studentName = name;
    }

    public virtual void AcceptDetails(int id, string name){
    
        this.studentName = name;
        this.studentId = id;

    }

    public virtual void DisplayDetails(){
        Console.WriteLine("Student Id: " + studentId);
        Console.WriteLine("Student Name: " + studentName);
    
    }
}