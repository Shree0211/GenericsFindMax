namespace MaximumGenerics;

internal static class TestCases
{
    // Test case array attributes
    private static readonly int[] intTestCase1;
    private static readonly int[] intTestCase2;
    private static readonly int[] intTestCase3;
    private static readonly float[] floatTestCase1;
    private static readonly float[] floatTestCase2;
    private static readonly float[] floatTestCase3;
    private static readonly string[] stringTestCase1;
    private static readonly string[] stringTestCase2;
    private static readonly string[] stringTestCase3;

    // Generic class objects
    private static Maximum<int> maxInt;
    private static Maximum<float> maxFloat;
    private static Maximum<string> maxString;

    /// <summary>
    /// Initializes the <see cref="TestCase"/> class.
    /// </summary>
    static TestCases()
    {
        intTestCase1 = new int[] { 18, 6, 17 };
        intTestCase2 = new int[] { 1, 9, 6 };
        intTestCase3 = new int[] { 19, 8, 22 };
        floatTestCase1 = new float[] { 9.9f, 1.7f, 7.8f };
        floatTestCase2 = new float[] { 1.1f, 7.7f, 5.2f };
        floatTestCase3 = new float[] { 2.1f, 5.5f, 7.7f };
        stringTestCase1 = new string[] { "Abc", "Apple", "Abcd" };
        stringTestCase2 = new string[] { "B", "Badminton", "B" };
        stringTestCase3 = new string[] { "C", "C", "Cabbage" };
        maxInt = new(intTestCase1);
        maxFloat = new(floatTestCase1);
        maxString = new(stringTestCase1);
    }

    /// <summary>
    /// returns the specified test case as string.
    /// </summary>
    /// <returns>Test case values as string</returns>
    private static string GetString<T>(T[] testCase)
    {
        return $"[{testCase[0]}, {testCase[1]}, {testCase[2]}]";
    }

    /// <summary>
    /// Tests the max function for 3 int.
    /// </summary>
    public static void IntTest()
    {
        Console.WriteLine("Test case 1: " + GetString(intTestCase1));
        maxInt.Max(intTestCase1[0], intTestCase1[1], intTestCase1[2]);
        Console.WriteLine("Test case 2: " + GetString(intTestCase2));
        maxInt.Max(intTestCase2[0], intTestCase2[1], intTestCase2[2]);
        Console.WriteLine("Test case 3: " + GetString(intTestCase3));
        maxInt.Max(intTestCase3[0], intTestCase3[1], intTestCase3[2]);
    }

    /// <summary>
    /// Tests the max function for 3 float.
    /// </summary>
    public static void FloatTest()
    {
        Console.WriteLine("Test case 1: " + GetString(floatTestCase1));
        maxFloat.Max(floatTestCase1[0], floatTestCase1[1], floatTestCase1[2]);
        Console.WriteLine("Test case 2: " + GetString(floatTestCase2));
        maxFloat.Max(floatTestCase2[0], floatTestCase2[1], floatTestCase2[2]);
        Console.WriteLine("Test case 3: " + GetString(floatTestCase3));
        maxFloat.Max(floatTestCase3[0], floatTestCase3[1], floatTestCase3[2]);
    }

    /// <summary>
    /// Tests the max function for 3 strings
    /// </summary>
    public static void StringTest()
    {
        Console.WriteLine("Test case 1: " + GetString(stringTestCase1));
        maxString.Max(stringTestCase1[0], stringTestCase1[1], stringTestCase1[2]);
        Console.WriteLine("Test case 2: " + GetString(stringTestCase2));
        maxString.Max(stringTestCase2[0], stringTestCase2[1], stringTestCase2[2]);
        Console.WriteLine("Test case 3: " + GetString(stringTestCase3));
        maxString.Max(stringTestCase3[0], stringTestCase3[1], stringTestCase3[2]);
    }
}