using System.Security.Cryptography;

static class Calculator{
    static int count = 0;
    static Calculator(){
         count = 0;
    }

    public static int increment() {
        count++;
        return count;
    }

    public static int decrement() {
        count--;
        return count;
    }
}