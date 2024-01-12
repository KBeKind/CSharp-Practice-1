


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
student1.displayDetails();

Student aStudent = new Student(3, "Duder");
aStudent.displayDetails();

aStudent.acceptDetails("Klee", 1);

aStudent.displayDetails();