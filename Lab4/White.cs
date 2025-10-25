using System.Globalization;

namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            for (int i = 0; i < vector.Length; i++)
            {
                length += vector[i] * vector[i];
            }

            length = Math.Sqrt(length);
            // end

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > P && array[i] < Q)
                {
                    count++;
                }
            }
            // end

            return count;
        }
        public void Task3(int[] array)
        {

            // code here
            int imaxim = 0;
            bool all_elems_equal = true;

            for (int i = 1; i < array.Length + 1; i++)
            {
                if (array[i - 1] > array[imaxim])
                {
                    imaxim = i - 1;
                }
                if (i < array.Length && array[i - 1] != array[i])
                {
                    all_elems_equal = false;
                }
            }

            if (imaxim != array.Length - 1 && !all_elems_equal)
            {
                int iminim = imaxim + 1;

                for (int i = imaxim + 1; i < array.Length; i++)
                {
                    if (array[i] < array[iminim])
                    {
                        iminim = i;
                    }
                }

                (array[imaxim], array[iminim]) = (array[iminim], array[imaxim]);
            }
            // end
            
        }
        public void Task4(int[] array)
        {

            // code here
            int imaxim = 0;

            for (int i = 0; i < array.Length; i += 2)
            {
                if (array[i] > array[imaxim])
                {
                    imaxim = i;
                }
            }

            array[imaxim] = imaxim;
            // end

        }
        public int Task5(int[] array, int P)
        {
            int index = 0;

            // code here
            bool found = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == P)
                {
                    index = i;
                    found = true;
                    break;
                }
            }
            
            if (!found)
            {
                index = -1;
            }
            // end

            return index;
        }
        public void Task6(int[] array)
        {

            // code here
            int imaxim = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[imaxim])
                {
                    imaxim = i;
                }
            }

            if (imaxim >= 2)
            {
                for (int i = 0; i < imaxim; i += 2)
                {
                    if (i < imaxim && i + 1 < imaxim)
                    {
                        (array[i], array[i + 1]) = (array[i + 1], array[i]);
                    }
                }
            }
            // end

        }
        public int[] Task7(int[] array)
        {
            int[] answer = null;

            // code here
            int amount_pos = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    amount_pos++;
                }
            }

            answer = new int[amount_pos];
            int j = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    answer[j] = array[i];
                    j++;
                }
            }
            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                }
            }
            // end

        }
        public void Task9(int[] array)
        {

            // code here
            for (int i = 0; i < array.Length / 2; i++)
            {
                (array[i], array[array.Length - i - 1]) = (array[array.Length - i - 1], array[i]);
            }
            // end

        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            if (A.Length == 0 && B.Length == 0)
            {
                C = new int[0];
            }
            else if (A.Length == 0)
            {
                C = B;
            }
            else if (B.Length == 0)
            {
                C = A;
            } else
            {
                C = new int[A.Length + B.Length];
                int j = 0;

                for (int i = 0; i < Math.Max(A.Length, B.Length); i++)
                {
                    if (i < A.Length)
                    {
                        C[j] = A[i];
                        j++;
                    }
                    if (i < B.Length)
                    {
                        C[j] = B[i];
                        j++;
                    }
                }
            }            
            
            // end

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
            if (a == b && n == 1)
            {
                array = new double[1] { a };
            }
            
            if (a != b && n >= 2)
            {
                array = new double[n];
                double step = (b - a) / (n - 1);
                int j = 0;

                for (double i = 0; i < n; i++)
                {
                    array[j] = a + step * i;
                    j++;
                }
            }
            // end

            return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here
            if (raw.Length >= 3)
            {
                bool all_elems_m_one = true;

                for (int i = 0; i < raw.Length; i++)
                {
                    if (raw[i] != -1)
                    {
                        all_elems_m_one = false;
                    }
                }

                if (all_elems_m_one)
                {
                    restored = raw;
                } else
                {
                    for (int i = 0; i < raw.Length; i++)
                    {
                        if (i == 0 && raw[i] == -1)
                        {
                            raw[0] = (raw[1] + raw[raw.Length - 1]) / 2;
                        }
                        else if (i == raw.Length - 1 && raw[i] == -1)
                        {
                            raw[raw.Length - 1] = (raw[0] + raw[raw.Length - 2]) / 2;
                        }
                        else if (raw[i] == -1 && raw[i - 1] != -1 && raw[i + 1] != -1)
                        {
                            raw[i] = (raw[i - 1] + raw[i + 1]) / 2;
                        }
                    }

                    restored = raw;
                }
            }
            // end

            return restored;
        }
    }
}
