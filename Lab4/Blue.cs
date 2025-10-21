using System.Buffers;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int max_elem = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max_elem)
                {
                    max_elem = array[i];
                }
            }

            int summ = 0;
            bool we_met_it = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (we_met_it)
                {
                    summ += array[i];
                }
                if (array[i] == max_elem)
                {
                    we_met_it = true;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = summ;
                    break;
                }
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int? index_last_pos = null;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] > 0)
                {
                    index_last_pos = i;
                    break;
                }
            }

            if (index_last_pos != null)
            {
                answer = new int[array.Length + 1];
                int j = 0;
                for (int i = 0; i < array.Length + 1; i++)
                {
                    if (i != index_last_pos + 1)
                    {
                        answer[i] = array[j];
                        j++;
                    } else
                    {
                        answer[i] = P;
                    }
                }
            } else
            {
                answer = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                    answer[i] = array[i];
            }
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            int index_min_pos_elem = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    if (index_min_pos_elem == -1 || array[i] < array[index_min_pos_elem])
                    {
                        index_min_pos_elem = i;
                    }
                }
            }

            if (index_min_pos_elem == -1)
            {
                answer = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                    answer[i] = array[i];
            } else
            {
                answer = new int[array.Length - 1];
                int j = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (i != index_min_pos_elem)
                    {
                        answer[j] = array[i];
                        j++;
                    }
                }   
            }
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            double summ_aray = 0;

            for (int i = 0; i < array.Length; i++)
            {
                summ_aray += array[i];
            }

            double avg = summ_aray / array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] -= avg;
            }
            // end  

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            if (A.Length == B.Length)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    sum += A[i] * B[i];
                }
            }
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            double summ = 0;

            for (int i = 0; i < array.Length; i++)
            {
                summ += array[i];
            }

            double avg = summ / array.Length;
            int how_many = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < avg)
                {
                    how_many++;
                }
            }

            if (how_many > 0)
            {
                indexes = new int[how_many];
                int j = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < avg)
                    {
                        indexes[j] = i;
                        j++;
                    }
                }
            } else
            {
                indexes = new int[0];
            }
            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            int inc = 1;
            int dec = 1;
            count = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    inc++;
                    dec = 1;
                }
                else if (array[i] < array[i - 1])
                {
                    dec++;
                    inc = 1;
                }
                else
                {
                    inc++;
                    dec++;
                }

                count = Math.Max(count, Math.Max(inc, dec));
            }
            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            if (array.Length > 0)
            {
                answer = new int[array.Length * 2];

                int j = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    answer[j] = array[i];
                    j++;
                    answer[j] = array[i];
                    j++;
                }
            } else
            {
                answer = new int[0];
            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            if (array.Length > 0)
            {
                normalized = new double[array.Length];
                int minim = array[0], maxim = array[0];

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < minim)
                    {
                        minim = array[i];
                    }
                    if (array[i] > maxim)
                    {
                        maxim = array[i];
                    }
                }

                if (minim == maxim)
                {
                    normalized = null;
                } else
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        normalized[i] = (double)(array[i] - minim) / (maxim - minim);
                    }
                }
            } else
            {
                normalized = new double[0];
            }
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                }
            }

            int left = 0;
            int right = array.Length - 1;
            bool touched = false;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == P)
                {
                    index = mid;
                    touched = true;
                    break;
                }

                if (array[mid] < P)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
           
            if (!touched)
            {
                index = -1;
            }
            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
            if (b > 0)
            {
                int len_array = 0;

                for (int i = a; i <= c; i += b)
                {
                    len_array++;
                }

                array = new int[len_array];
                int j = 0;
                for (int i = a; i <= c; i += b)
                {
                    array[j] = i;
                    j++;
                }
            }

            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here

            if (magazine.Length >= 3)
            {
                double max_sum = -1;
                indexes = new int[3];

                for (int i = 2; i < magazine.Length; i++)
                {
                    if (magazine[i - 2] + magazine[i - 1] + magazine[i] > max_sum)
                    {
                        indexes[0] = i - 2;
                        indexes[1] = i - 1;
                        indexes[2] = i;
                        max_sum = magazine[i - 2] + magazine[i - 1] + magazine[i];
                    }
                }
            }
            else if (magazine.Length == 2)
            {
                indexes = new int[2];
                indexes[0] = 0;
                indexes[1] = 1;
            }
            else if (magazine.Length == 1)
            {
                indexes = new int[1];
                indexes[0] = 0;
            }           
            
            // end

            return indexes;
        }
    }
}
