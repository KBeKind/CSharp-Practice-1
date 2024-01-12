
using System.Linq.Expressions;


using System.Collections;
using System.Text;

float baseSalary = 100000;
float hra = 0.30F;

float netSalary = (baseSalary - (baseSalary * hra));

Console.WriteLine("Base Salary: " + baseSalary);
Console.WriteLine("Net Salary: " + netSalary);

int temperature = 51;
if(temperature < 20) {
    Console.WriteLine("its very cold");
} else if (temperature >= 20 && temperature <= 50) {
    Console.WriteLine("its not cold");
} else {
    Console.WriteLine("its very hot");
}

bool isLoggedIn = true;
bool isAuthenticated = true;
bool isEmailVerified = true;
bool cardInfo = true;

if(isLoggedIn && isEmailVerified && isAuthenticated && cardInfo) {

Console.WriteLine("Allow to make a purchase");
Console.WriteLine("Also you are logged in");
} else {
    Console.WriteLine("Not allowed to make a purchase");
}




int j = 1;

do {
    Console.WriteLine(j);
    j++;
} while (j < 20);

string[] names = new string[5] {"Tim", "John", "Sally", "Sammy", "Tony"};

foreach (string name in names)
{
    Console.WriteLine(name);
}
Console.WriteLine("_____________________");

for (int i =0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}
Console.WriteLine("_____________________");

int k = 0;

while( k < names.Length)
{
    Console.WriteLine(names[k]);
    if (names[k] == "Sammy") {
        break;
    } else if (names[k] == "John") {
         k++;
        continue;
    }
    k++;
}

Console.WriteLine("_____________________");



string userType = "admin";

switch(userType) {
    case "admin":
        Console.WriteLine("Welcome Admin");
        goto case "user";
    case "user":
        Console.WriteLine("Welcome User");
        break;
    default:
        Console.WriteLine("Welcome Guest");
        break;
}

Console.WriteLine("_____________________");

int[] marks = new int[5];

marks[0] = 10;
marks[1] = 20;
marks[2] = 30;
marks[3] = 40;
marks[4] = 50;

foreach (int item in marks)
{
    Console.WriteLine(item);
}
Console.WriteLine("_____________________");

int[,] multiArray = new int[2,3];
multiArray[0,0] = 10;
multiArray[0,1] = 20;
multiArray[0,2] = 30;
multiArray[1,0] = 40;
multiArray[1,1] = 50;
multiArray[1,2] = 60;

foreach (int item in multiArray){
    Console.WriteLine(item);

}
Console.WriteLine("_____________________");

int[,] multiArray2 = new int[2,3] {{10,20,30},{40,50,60}};

foreach (int item in multiArray2){
    Console.WriteLine(item);

}
Console.WriteLine("_____________________");

for (int i = 0; i < multiArray2.GetLength(0); i++)
{
    for (int l = 0; l < multiArray2.GetLength(1); l++)
    {
        Console.WriteLine(multiArray2[i,l]);
    }
}


int[][] jaggedArray = new int[2][];
jaggedArray[0] = new int[2] {10,20};
jaggedArray[1] = new int[3] {30,40,50};

for (int i = 0; i < jaggedArray.Length; i++)
{
    for (int l = 0; l < jaggedArray[i].Length; l++)
    {
        Console.WriteLine(jaggedArray[i][l]);
    }
}


string str1 = "Hello";

Console.WriteLine(str1);
Console.WriteLine(str1.Length);

string str2 = "Hello World";
string str12 = String.Concat(str1,str2);
Console.WriteLine(str12);

Console.WriteLine(str1.Equals(str2));

Console.WriteLine(str1 + str2);

string str3 = "Java";
string str4 = "C#";

StringBuilder aStringBuilder = new StringBuilder();

aStringBuilder.Append(str3);
aStringBuilder.Append(" " + str4);

Console.WriteLine(aStringBuilder);


Student student1 = new Student();
student1.DisplayDetails();

Student aStudent = new Student(3, "Duder");
aStudent.DisplayDetails();

aStudent.AcceptDetails( 1, "Klee");

aStudent.DisplayDetails();


Marks marks1 = new Marks();
//marks1.AcceptDetails(1, "KDawg");
//marks1.DisplayDetails();



SavingAccount aSavingAccount = new SavingAccount();

aSavingAccount.getMessage();

aSavingAccount.deposit();

aSavingAccount.getBalance();

aSavingAccount.withdraw();


SavingAcc aSavingAcc = new SavingAcc();

aSavingAcc.openAccount();
aSavingAcc.deposit();
aSavingAcc.balance();
aSavingAcc.withdraw();

Console.WriteLine(Calculator.increment());
Console.WriteLine(Calculator.increment());
Console.WriteLine(Calculator.increment());
Console.WriteLine(Calculator.decrement());


int number = 100;

bool result = number.IsGreaterThan(1000);
Console.WriteLine(result);


Employee emp1 = new Employee();

emp1.DisplayDetails();


User user = new User();

user.Name = "Duderman";
user.Age = 33;
user.City = "St Louis";
Console.WriteLine(user.Name);
Console.WriteLine(user.CompanyName);
Console.WriteLine(user.Age);
Console.WriteLine(user.City);


StringIndexerType stringIndexerType = new StringIndexerType();
stringIndexerType[0] = "Hello";
stringIndexerType[1] = "World";
stringIndexerType[2] = "Duderman";
stringIndexerType[3] = "Duder";
stringIndexerType[4] = "Dude";

for (int i=0; i<10; i++) {
    Console.WriteLine(stringIndexerType[i]);
}


Months months = new Months();
months.display();

Calculation calculation = new Calculation();
calculation.calculate(100, 0);

calculation.calculate(100, 10);

// calculation.calculate2();


var anonObj = new {
    firstName = "Duder",
    lastName = "Dudeman",
    salary = 10000000,
    address = new {
        streetname = "Duderstreet",
        city = "Dudercity",
    },
    projects = new[] {
        new {projectname = "Duderproject", projectdescription = "Duderdescription"},
        new {projectname = "Duderproject2", projectdescription = "Duderdescription2"},
        new {projectname = "Duderproject3", projectdescription = "Duderdescription3"},
    }
};


Console.WriteLine(anonObj.firstName);
Console.WriteLine(anonObj.lastName);
Console.WriteLine(anonObj.salary);
Console.WriteLine(anonObj.address.streetname);
Console.WriteLine(anonObj.address.city);

foreach (var project in anonObj.projects) {
    Console.WriteLine(project.projectname + ": " + project.projectdescription);
}


CalculateDelegate c1 = new CalculateDelegate(DelegateExample.addition);
CalculateDelegate c2 = new CalculateDelegate(DelegateExample.multiplication);

c1(100);
Console.WriteLine(DelegateExample.getNumber());
c2(200);
Console.WriteLine(DelegateExample.getNumber());


// SUBSCRIBER MODEL
EventsExample events = new EventsExample();
events.event_OddNumber += new EventsExample.delegate_OddNumber(EventMessage);
events.addition();

static void EventMessage() {
    Console.WriteLine("Event Executed: Odd Number");
}

AnonymousMethod.InvokeMethod();


int[] someNumbers = new int[] {2, 4, 6, 7, 1, 3, 10, 5, 5};

// EXPRESSION LAMBDA
var count = someNumbers.Count( n => n == 5 );

// SAME STUFF BUT WITHOUT THE LAMBDA
static bool CheckedIfFive(int aNum) { return aNum == 5; }
var count2 = someNumbers.Count(CheckedIfFive);

Console.WriteLine(count);
Console.WriteLine(count2);

// STATEMENT LAMBDA
List<int> numbers2 = new List<int> {2, 4, 6, 7, 1, 3, 10, 5, 5};
var count3 = numbers2.Count(n => { return n==5; });
Console.WriteLine(count3);



//Func<string, string, string> stringJoins = (str1, str2) => string.Concat(str1, str2);

// EXPRESSION TREE
Expression<Func<string, string, string>> stringJoinExpr = (str1, str2) => string.Concat(str1, str2);

var func = stringJoinExpr.Compile();
var resultAgain = func("Hello", " What up");

Console.WriteLine(resultAgain);

// THE TWO ABOVE CAN BE ON ONE LINE
resultAgain = stringJoinExpr.Compile()("Hello", " What up");

Console.WriteLine(resultAgain);