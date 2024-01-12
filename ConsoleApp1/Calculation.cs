internal class Calculation {
    public void calculate(int num1, int num2) {

        int result = 0;
        try {
        result = num1 / num2;
        } catch(Exception e) {
            Console.WriteLine("You Made an error dividing by zero you silly goose!");
            Console.WriteLine(e.Message);
        } finally {
            Console.WriteLine("This will always print");
            Console.WriteLine("This is your current result: " + result);
        }
       
    }

     public void calculate2() {

        int num1, num2, result = 0;
        try {

        Console.Write("enter first number to divide: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("enter second number to divide: ");
        num2 = int.Parse(Console.ReadLine());
        result = num1 / num2;
        } catch(FormatException e) {
            Console.WriteLine("What you gave me was no good!");
            Console.WriteLine(e.Message);
        } catch(DivideByZeroException e) {
            Console.WriteLine("You Made an error dividing by zero you silly goose!");
            Console.WriteLine(e.Message);
        } catch(Exception e) {
            Console.WriteLine("Something went wrong.. WE DIDNT PLAN FOR THIS!!");
            Console.WriteLine(e.Message);
        } finally {
            Console.WriteLine("This will always print");
            Console.WriteLine("This is your current result: " + result);
        }
       
    }


}