namespace BUV26_260908_Konvert_Felsökning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Implicit 
            //int NumberInt = 50;
            //double Numberdouble = NumberInt;
            //Console.WriteLine(Numberdouble);


            ////Explicit 

            //float FNumber = 9635252.25f;
            //int INumber = (int)FNumber; // Type Casting
            //int INumber2 = Convert.ToInt32(FNumber); // Convert Class


            //Console.WriteLine(INumber);



            //Parse () && TryParse 
          //  string strNum = "589";
          //  //int InNum = int.Parse(strNum);
          //  //Console.WriteLine(InNum + 100);

          //  int result = 0;

          //bool IsConverted =   int.TryParse(strNum, out result);


          //  if (IsConverted)
          //  {
          //      Console.WriteLine("Result is {0}", result);
          //  }
          //  else
          //  {
          //      Console.WriteLine("Pleas Enter a valid Number");
          //  }


            Console.ReadKey();

        }
    }
    class User 
    {
        string name = "Anas";
    }
}
