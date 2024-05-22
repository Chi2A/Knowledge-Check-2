// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<MyClass>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var myClass = new MyClass();

    Console.WriteLine("Enter the value for ");
    myClass.myProperty = Console.ReadLine();

    recordList.Add(myClass);
}

// Print out the list of records using Console.WriteLine()

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<DerivedClass>();
for (int i = 0; i < numberOfRecords; i++)
{
    var derivedClass = new DerivedClass();

    Console.WriteLine("Enter the value for BaseProperty: ");
    derivedClass.BaseProperty = Console.ReadLine();

    Console.WriteLine("Enter the value for DerivedProperty: ");
    derivedClass.DerivedProperty = Console.ReadLine();

    recordList.Add(derivedClass);
}

// Print out the list of records using Console.WriteLine()
foreach (var record in recordList)
{
    Console.WriteLine(record);
}