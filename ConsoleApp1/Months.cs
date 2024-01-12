


enum MonthsEnum {
    January,
    February,
    March,
    April,
    May,
    June,
    July,
}

internal class Months {
    public void display() {
        int aMonth = (int)MonthsEnum.March;
        Console.WriteLine(MonthsEnum.March + " : " + aMonth);
        aMonth = (int)MonthsEnum.April;
        Console.WriteLine(MonthsEnum.April + " : " + aMonth);
        aMonth = (int)MonthsEnum.May;
        Console.WriteLine(MonthsEnum.May + " : " + aMonth);
    }

}
