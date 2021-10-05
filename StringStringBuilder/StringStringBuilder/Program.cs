using System;
using System.Text;
using System.Text.RegularExpressions;

namespace StringStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Value,Reference
            //int num1 = 5;
            //int num2 = num1; //num2=5
            //num2 = 10;
            //Console.WriteLine($"num1={num1}");
            //Console.WriteLine($"num2={num2}");
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = arr1; //arr2->arr1 address
            //arr2[0] = 100;
            //Console.WriteLine($"arr1={arr1[0]}");
            //Console.WriteLine($"arr2={arr2[0]}");


            //int a=10;
            //ChangeNumber(ref a); //ChangeNumber(10)
            //Console.WriteLine(a);
            //int[] arr = { 1, 2, 3 };
            //ChangeArr(arr);
            //Console.WriteLine(arr[0]);
            #endregion

            #region String
            //string name1 = "Kamran";
            //string name2 = name1;
            //name2 = "Altun";
            //string name3 = "Altun";
            //Console.WriteLine($"name1={name1}");
            //Console.WriteLine($"name2={name2}");
            //Console.WriteLine(name3==name2);
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = { 1, 2, 3 };
            //Console.WriteLine(arr2==arr1);
            //string word = "Hello123Hi456Bye"; //hellO
            //string[] arr = Regex.Split(word, @"\d+");
            //string[] arr = word.Split("@ ");
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //string search = "Ell";
            //Console.WriteLine(word.ToLower().Contains(search.Trim().ToLower()));
            //Console.WriteLine(word.ToLower()==search.Trim().ToLower());
            //Console.WriteLine(word.Trim().Length);
            //string word2 = "ByeHello";
            //Console.WriteLine(String.Compare(word,0,word2,3,5));
            #endregion

            #region StringBuilder
            //Console.WriteLine(Reverse("Murad"));
            //StringBuilder str = new StringBuilder();
            //str.Append("Ka");
            //str.Append("mran");
            //Console.WriteLine(str.Length);

            #endregion

            #region Array
            //int[] arr = { 1, 2, 3,4,5,6 };
            //int[] arr1 = new int[3] {1,2,3 };
            //Array.Resize(ref arr1, 4);
            //arr1[3] = 40;
            #endregion
        }

        #region StringBuilder
        //static StringBuilder Reverse(string str)
        //{
        //    StringBuilder result = new StringBuilder();
        //    for (int i = str.Length - 1; i >= 0; i--)
        //    {
        //        result.Append(str[i]);
        //    }
        //    return result;
        //}
        //static string Reverse(string str)
        //{
        //    string result = String.Empty;
        //    for (int i = str.Length-1; i>=0 ; i--)
        //    {
        //        result += str[i];
        //    }
        //    return result;
        //}
        #endregion

        #region Value,Reference
        static void ChangeArr(int[] arr)
        {
            arr[0] = 1000;
            Console.WriteLine($"method-{arr[0]}");
        }
        static void ChangeNumber(ref int num)
        {
            num = 1000;
            Console.WriteLine($"method-{num}");
        }
        #endregion

        #region Method
        static long Factorial(int n)
        {
            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        #endregion

    }
}
