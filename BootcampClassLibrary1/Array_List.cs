using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BootcampClassLibrary1
{
    public class Array_List
    {
        public void DoSomethongWithList()
        {


            int[] array1 = new int[5];
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };
            int[] array3 = { 1, 2, 3, 4, 5, 6 };

            int[,] multiDimArray1 = new int[2, 3];
            int[,] multiDimArray2 = { { 1, 2, 3 }, { 2, 4, 6 } };

            int[][] jaggedArray = new int[6][];

            //jaggedArray[0]= new int[4] {1,2,3,4};


            // GENERIC LIST 

            List<int> mylist1 = new();

            mylist1.Add(2);

            mylist1 = new List<int>(array1);

            mylist1.Sort();

            mylist1.Remove(2);

            int[] anotherArray = mylist1.ToArray();

            bool b = mylist1.Contains(10);

            int? i = mylist1.Find(x => x == 7);

            int j = mylist1.Find(y => y == 70);


            foreach (int l in mylist1)
            {
                if (l == 7)
                {
                    i = l;
                    break;

                }

            }


            //Dictionary

            Dictionary<int, string> myDict = new();

            myDict.Add(10, "Ten");
            myDict.Add(11, "Eleven");
            myDict.Add(12, "Twelve");

            myDict.Clear();
            myDict = new Dictionary<int, string> { { 10, "ten" }, { 11, "Eleven" } };


            string s = myDict[11];

            bool k = myDict.ContainsKey(11);
            bool v = myDict.ContainsValue("Hello");
            foreach (KeyValuePair<int, string> kvp in myDict)
            {
                Debug.WriteLine($"Key = {kvp.Key} Value = {kvp.Value}");


            }

        }


             




    }
}
