
using GenericsFindMax;
using MaximumGenerics;

Console.WriteLine("-----Find Maximum using Generics------");

// Testing max value in 3 different positions
Console.WriteLine("Test case 1: " + TestCases.GetString(TestCases.IntTestCase1));
Maximum.FindIntMax(TestCases.IntTestCase1[0], TestCases.IntTestCase1[1], TestCases.IntTestCase1[2]);
Console.WriteLine("Test case 2: " + TestCases.GetString(TestCases.IntTestCase2));
Maximum.FindIntMax(TestCases.IntTestCase2[0], TestCases.IntTestCase2[1], TestCases.IntTestCase2[2]);
Console.WriteLine("Test case 3: " + TestCases.GetString(TestCases.IntTestCase3));
Maximum.FindIntMax(TestCases.IntTestCase3[0], TestCases.IntTestCase3[1], TestCases.IntTestCase3[2]);
