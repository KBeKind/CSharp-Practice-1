
// PUBLISHER MODEL
internal class EventsExample {

    // DECLARE DELEGATE
    public delegate void delegate_OddNumber();

    // DECLARE EVENT
    public event delegate_OddNumber event_OddNumber;

    public void addition() {

        int num1 = 100;
        int num2 = 200;
        int result = num1 + num2;
        Console.WriteLine("Addition is : " + result);

        if ( result % 2 != 0 && event_OddNumber != null) {
            // RAISED EVENT
            event_OddNumber();
        }
    }
}