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

            //Seas_on season;
            //bool isParsed;

            //Console.WriteLine("enter the season :");
            //do
            //{
            //    isParsed = Enum.TryParse<Seas_on>(Console.ReadLine(), out season);
            //} while (!isParsed);

            ////Console.WriteLine(season);


            //for (int i = 0; i < 8; i++)
            //{
            //    season = (Seas_on)i;
            //    Console.WriteLine(season);
            //}

            #endregion


            #region Q3

            Employee employee = new Employee();
            {
                employee.ID = 10;
                employee.permissions = (Permissions)6;
            };

            Console.WriteLine(employee.permissions);

            employee.permissions = employee.permissions | (Permissions)8;
            Console.WriteLine(employee.permissions);

            if ((employee.permissions & Permissions.Delete) == Permissions.Delete)
            {
                employee.permissions = employee.permissions ^ Permissions.Delete;
                Console.WriteLine(employee.permissions);

            }
            #endregion

            #region Q4

            //Colors primaryColor;
            //Colors color;
            //bool isParsed;
            //primaryColor = (Colors)7;
            //Console.WriteLine("Enter the color : ");
            //do
            //{
            //    isParsed= Enum.TryParse(Console.ReadLine(), out color);
            //} while (!isParsed);


            //if((primaryColor & color )== Colors.Red || (primaryColor & color)== Colors.Green || (primaryColor & color )== Colors.Blue)
            //    Console.WriteLine("Color is primary");
            //else
            //    Console.WriteLine("Color is not primary");



            #endregion
        }

    }
}
