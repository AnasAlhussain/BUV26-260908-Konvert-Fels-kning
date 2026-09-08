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
            //string strNum = "589ABC";
            //int InNum = int.Parse(strNum);
            //Console.WriteLine(InNum + 100);

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



            //Comp Error 

            //int num = 10;
            //Console.WriteLine(Num);

            ////Strong type 
            //string name = "Anas";
            //Console.WriteLine(name);
            //name = 10;

            //string name = "AAA";


            //int number = 1;
            //while (number < 10)
            //{
            //    Console.WriteLine(number);
            //    number += 3;
            //    if (number == 7)
            //    {
            //        Console.WriteLine("The number is 7");
            //    }
            //}


            try
            {
                string strNum = "589ABC";
                int InNum = int.Parse(strNum);
                Console.WriteLine(InNum + 100);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch
            {
                Console.WriteLine("Fel värde ");
            }

            

            Console.ReadKey();

        }
    }
    class User 
    {
        string name = "Anas";
    }

    class User2
    {
        string name = "Anas";
    }
}
