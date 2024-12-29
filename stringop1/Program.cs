using System;
using System.Linq; //find all chars in a text 

namespace stringop1
{


    internal class Program
    {

        static void Main(string[] args)
        {

            //reverse a text 

            string myText = "it is so nice to meet you but life is good and i really have no idea what to write here";

            //--------------------------reverse text --------------------------
            string reversedText = ReverseText(myText);
            Console.WriteLine(reversedText);

            //--------------------------remove spaces -----------------------------
            string noSpaceText = RemoveSpaces(myText);
            Console.WriteLine(noSpaceText);

            //--------------------------replace char with new one--------------------------

            string newReplacedText = ReplaceChar('i', 'a', myText);
            Console.WriteLine(newReplacedText);

            //---------------------------create sinus text -------------------------------------
            CreateSinusText(myText);


            //--find char inside a text first

            FindFirstChar('t', myText);

            //--find char inside a text last 
            FindLastChar('t', myText);

            //find all chards inside a text 
            FindAllChar('t', myText);

            //create a substring 
            CreateSubString('t', 4, myText);

            //find a text inside a text
            string searchedText = "life"; //exists 
            string searchedText1 = "school";

            FindSubString(searchedText, myText);
            FindSubString(searchedText1, myText);




        }
        //--end of main method 




        //----------------reverse text------------------
        public static string ReverseText(string anyText)
        {

            if (anyText == null)
            {

                return "text cannot be empty";
            }


            char[] textArray = anyText.ToCharArray();
            Array.Reverse(textArray);
            return new string(textArray);


        }

        //----------------remove spaces------------------

        public static string RemoveSpaces(string anyText)
        {
            string result = anyText.Replace(" ", ""); //remove all spaces 
            return result;
        }

        //--------------------------replace char with new one--------------------------


        public static string ReplaceChar(char oldChar, char newChar, string anyText)
        {
            string replacedText = anyText.Replace(oldChar, newChar);
            return replacedText;

        }

        //--------------------------split to chars and create sinus text--------------------------

        public static void CreateSinusText(string anyText)
        {
            if (string.IsNullOrWhiteSpace(anyText))
            {

                Console.WriteLine("Text cannot be null or empty.");
                return;

            }
            char[] charTextArray = anyText.ToUpper().ToCharArray();
            int counter = 0;

            foreach (char c in charTextArray)
            {
                double y = Math.Abs(Math.Sin(counter * 0.12) * 20);
                string fancyString = new string(' ', (int)y) + c;
                Console.WriteLine(fancyString);
                counter++;
            }


        }


        //find a char inside a text first occurrence 

        public static void FindFirstChar(char anyChar, string anyString)
        {
            int index = anyString.IndexOf(anyChar);

            Console.WriteLine($"there is {index} index  searched char {anyChar} in the text");

        }

        //find a char last in text 
        public static void FindLastChar(char anyChar, string anyString)
        {
            int index = anyString.LastIndexOf(anyChar);
            Console.WriteLine($"there is {index} index  searched char {anyChar} in the text");

        }

        //find all chars in text  using System.Linq; 

        public static void FindAllChar(char anyChar, string anyString)
        {
            int count = anyString.Count(c => c == anyChar);

            Console.WriteLine($"searched char {anyChar}  found {count} times inside the text");
        }

        //substring create a substring from a string 

        public static void CreateSubString(char anyChar, int position, string anyString)
        {
            int charPos = anyString.IndexOf(anyChar); //we get the first char in the text
            string searchText = anyString.Substring(charPos, position);
            Console.WriteLine(searchText);

        }


        //search string in a string 
        public static void FindSubString(string searchedText, string anyText)
        {
            if (anyText.Contains(searchedText))
            {
                Console.WriteLine($"substring {searchedText} exists in the text");
            }
            else
            {
                Console.WriteLine($"substring {searchedText} does not exist in the text");

            }
        }






    } //end of internal class 

}