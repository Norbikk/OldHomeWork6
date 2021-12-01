namespace HomeWork6old
{
    public class CoreComputation
    {
        /*  public static string GroupNumbers(int n)
        {
            int m = 0;
            int firstNum = 1;
            string str = null;

            for (int i = 1; i <= n; i++)
            {
                if (i % firstNum == 0)
                {
                    firstNum = i;
                    m++;
                    str += $"\nГруппа {m} : {i}";
                }
                else
                {
                    str += $" {i}";
                }
            }

            return str;
        }
        */

        
        public static int GroupsCount(int n)
        {
            int count = 0;
            int firstNum = 1;

            for (int i = 1; i <= n; i++)
            {
                if (i % firstNum == 0)
                {
                    firstNum = i;
                    count++;
                }
            }

            return count;
        }
    }
}