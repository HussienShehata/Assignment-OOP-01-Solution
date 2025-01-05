using AssignmentClassLibarary01;
namespace Assignment01

{
  
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1

            //WeekDays? day;
            //bool isParsed;
            //do
            //{
               
            //    isParsed = Enum.TryParse<WeekDays>(Console.ReadLine(), out day);
            //    Console.WriteLine(day);
            //} while (!isParsed || day is  null); 

            //for(int i=0; i<7;i++)
            //{
            //    day = (WeekDays)i;
            //    Console.WriteLine(day);
            //}
            #endregion


            #region Q2

            Seas_on? season;
            bool isParsed;

            do
            {
                isParsed = Enum.TryParse<Seas_on>(Console.ReadLine(), out );
            } while (!isParsed || season is null);






            #endregion
        }
    }
}
