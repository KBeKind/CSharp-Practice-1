
delegate int CalculateDelegate(int num);


internal class DelegateExample {
    static int number = 100;

    public static int addition( int num ) {
        number += num;
        return number;
    }

    public static int multiplication( int num ) {
        number *= num;
        return number;
    }

    public static int getNumber() {
        return number;
    }

}