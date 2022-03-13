using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsFindMax
{
    internal class TestCases
    {
        private static readonly int[] intTestCase1;
        private static readonly int[] intTestCase2;
        private static readonly int[] intTestCase3;
        private static readonly float[] floatTestCase1;
        private static readonly float[] floatTestCase2;
        private static readonly float[] floatTestCase3;


        static TestCases()
        {
            intTestCase1 = new int[] { 18, 6, 17 };
            intTestCase2 = new int[] { 1, 9, 6 };
            intTestCase3 = new int[] { 19, 8, 22 };
            floatTestCase1 = new float[] { 9.9f, 1.7f, 7.8f };
            floatTestCase2 = new float[] { 1.1f, 7.7f, 5.2f };
            floatTestCase3 = new float[] { 2.1f, 5.5f, 7.7f };

        }


        public static int[] IntTestCase1 => intTestCase1;
        public static int[] IntTestCase2 => intTestCase2;
        public static int[] IntTestCase3 => intTestCase3;
        public static float[] FloatTestCase1 => floatTestCase1;
        public static float[] FloatTestCase2 => floatTestCase2;
        public static float[] FloatTestCase3 => floatTestCase3;

        public static string GetString<T>(T[] testCase)
        {
            return $"[{testCase[0]}, {testCase[1]}, {testCase[2]}]";
        }
    }
}
