internal class Marks: Student {

    float objectiveMarks;
    float subjectiveMarks;

    public Marks() {
        this.objectiveMarks = 0;
        this.subjectiveMarks = 0;
    }

    public override void AcceptDetails(int id, string name){

        base.AcceptDetails(id, name);
        Console.Write("Enter Objective Marks: ");
        objectiveMarks = float.Parse(Console.ReadLine());
        Console.Write("Enter Subjective Marks: ");
        subjectiveMarks = float.Parse(Console.ReadLine());

    }

    public override void DisplayDetails(){
        base.DisplayDetails();
        Console.WriteLine("Objective Marks: " + objectiveMarks);
        Console.WriteLine("Subjective Marks: " + subjectiveMarks);

    }


}