namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            double a1 = Math.Abs(d);
            answer = a1 >= 0;
            // end

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            // code here
            double b2 = d + f / 2;
            answer = b2 > 0;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            answer = a + b > (Math.Abs(a) + Math.Abs(b)) / 2;
            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            answer = Math.Max(a, Math.Max(b, c));
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (Math.Abs(x) <= 1)
            {
                answer = Math.Pow(x, 2) - 1;
            }
            // end

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            if ((y >= 0) && (y <= 1 - x) && (y <= 1 + x))
            {
                answer = true;
            }
            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here
            if (n < 0)
            {
                answer = false;
            }
            else
            {
                if (n%2 == 0)
                {
                    answer = false;
                }
            }
                // end

                return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            // code here
            int days = X;
            int wakeup = 14;
            int sleep = 4;

            for (int day = 0; day <= days; day++)
            {
                wakeup -= 1;
                if (day % 2 == 0)
                {
                    sleep -= Y / 60;
                }
                int sleep1 = wakeup - sleep;
                if (sleep1 >= 7 && sleep1 <= 9 && wakeup == 7)
                {
                    answer = true;
                    break;
                }
                if (sleep < 0) sleep += 24;
                if (wakeup < 0) wakeup += 24;
            }
                // end

                return answer;
        }
    }
}