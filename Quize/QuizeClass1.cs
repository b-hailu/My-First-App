using System;

namespace Quize
{
    public class QuizeClass1
    {
        public string SampleGrade(string grd)


        {




            switch (grd)
            {
                case "E":
                    return "excelent";

                case "V":
                    return "Very Good";

                case "G":
                    return "Good";

                case "A":
                    return "Avarage";

                case "F":
                    return "Fail";
                default:

                    return "Invalid Grade Found";



            }



        }
        public void QuizeMath()

        {
            for (int i = 0; i < 50; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }


    }
}


