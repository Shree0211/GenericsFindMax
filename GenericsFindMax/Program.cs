
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


Console.WriteLine("Test case 1: " + TestCases.GetString(TestCases.FloatTestCase1));
Maximum.FloatMax(TestCases.FloatTestCase1[0], TestCases.FloatTestCase1[1], TestCases.FloatTestCase1[2]);
Console.WriteLine("Test case 2: " + TestCases.GetString(TestCases.FloatTestCase2));
Maximum.FloatMax(TestCases.FloatTestCase2[0], TestCases.FloatTestCase2[1], TestCases.FloatTestCase2[2]);
Console.WriteLine("Test case 3: " + TestCases.GetString(TestCases.FloatTestCase3));
Maximum.FloatMax(TestCases.FloatTestCase3[0], TestCases.FloatTestCase3[1], TestCases.FloatTestCase3[2]);

Console.WriteLine("Test case 1: " + TestCases.GetString(TestCases.StringTestCase1));
Maximum.StringMax(TestCases.StringTestCase1[0], TestCases.StringTestCase1[1], TestCases.StringTestCase1[2]);
Console.WriteLine("Test case 2: " + TestCases.GetString(TestCases.StringTestCase2));
Maximum.StringMax(TestCases.StringTestCase2[0], TestCases.StringTestCase2[1], TestCases.StringTestCase2[2]);
Console.WriteLine("Test case 3: " + TestCases.GetString(TestCases.StringTestCase3));
Maximum.StringMax(TestCases.StringTestCase3[0], TestCases.StringTestCase3[1], TestCases.StringTestCase3[2]);

