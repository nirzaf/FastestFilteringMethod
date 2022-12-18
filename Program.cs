// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using BenchmarkDotNet.Running;
using Bogus;
using FastestFilteringMethod;

Console.WriteLine("Testing the fastest way to filter from the list");

//BenchmarkRunner.Run<ConvertDateToString>();

//Array of Random Alphabetical letter char array
var randomAlphabeticalLetters = new Faker().Random.AlphaNumeric(1000).ToCharArray();

foreach (var c in randomAlphabeticalLetters)
{
    Console.Write(c +" ");
}

// char array of random int numbers with 20 elements

/*
var randomIntNumbers = new Faker().Random.Int(10,1000).ToString().ToCharArray();

foreach (var c in randomIntNumbers)
{
    Console.Write(c +" ");
}
*/

Console.ReadLine();

/*var listOfStudents = new Faker<Student>()
    .RuleFor(s => s.Id, f => f.Random.Guid())
    .RuleFor(s => s.Name, f => f.Name.FirstName())
    .RuleFor(s => s.Surname, f => f.Name.LastName())
    .RuleFor(s=>s.Age,f=>f.Random.Int(5,18))
    .RuleFor(s=>s.Email,f=>f.Internet.Email())
    .RuleFor(s=>s.Phone,f=>f.Phone.PhoneNumber()
    ).Generate(10000);

//Convert listOfStudent as ReadOnly list
var listOfStudentsReadOnly = listOfStudents.AsReadOnly();

//Filter students between age 13 to 18
   var stopWatch = new Stopwatch();
    stopWatch.Start();
    var filteredStudents = listOfStudents.Where(s => s.Age is >= 13 and <= 18).ToList();
    stopWatch.Stop();
    Console.WriteLine($"Time taken by Where method: {stopWatch.ElapsedTicks} ticks");

stopWatch.Restart();
var filteredStudentsFromReadOnlyList = listOfStudentsReadOnly.Where(s => s.Age is >= 13 and <= 18);
stopWatch.Stop();
Console.WriteLine($"Time taken by ReadOnly List: {stopWatch.ElapsedTicks} ticks");

var newFilteredList = new List<Student>();
stopWatch.Restart();
foreach (var student in listOfStudents)
{
    if(student.Age>=13 && student.Age<=18)
    {
        newFilteredList.Add(student);
    }
}
stopWatch.Stop();
Console.WriteLine($"Time taken by foreach method: {stopWatch.ElapsedTicks} ticks");

// Print the count of filtered students list
Console.WriteLine($"Count of filtered students list: {newFilteredList.Count}");
    
Console.ReadLine();*/