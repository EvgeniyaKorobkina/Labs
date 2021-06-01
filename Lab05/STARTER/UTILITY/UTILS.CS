namespace Utils
    {
        using System;

        public class Utils
        {
        public static bool Factorial(int n, out int answer)
            {
                int k;
                int f;
                bool ok = true;

                if (n < 0)
                    ok = false;

                try
                {
                    checked
                    {
                        f = 1;
                        for (k = 2; k <= n; ++k)
                        {
                            f = f * k;
                        }
                    }
                }
                catch (Exception)
                {

                    f = 0;
                    ok = false;
                }

                answer = f;
                return ok;
            }
        }
}


