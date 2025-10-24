using System.Collections.Specialized;
using System.Globalization;

namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            double summ = 0;
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    summ += array[i];
                    count++;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = summ / count;
                }
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            bool was_neg = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    was_neg = true;
                    break;
                }
                sum += array[i] * array[i];
            }

            if (!was_neg)
            {
                sum = 0;
            }
            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here

            int i_maxim = 0, i_minim = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[i_maxim])
                {
                    i_maxim = i;
                }
                if (array[i] < array[i_minim])
                {
                    i_minim = i;
                }
            }

            int j = 0, count_neg = 0;

            if (i_maxim < i_minim)
            {
                for (int i = i_maxim + 1; i < i_minim; i++)
                {
                    if (array[i] < 0)
                    {
                        count_neg++;
                    }
                }

                negatives = new int[count_neg];

                for (int i = i_maxim + 1; i < i_minim; i++)
                {
                    if (array[i] < 0)
                    {
                        negatives[j] = array[i];
                        j++;
                    }
                }
            }
            else if (i_maxim > i_minim)
            {
                for (int i = i_minim + 1; i < i_maxim; i++)
                {
                    if (array[i] < 0)
                    {
                        count_neg++;
                    }
                }

                negatives = new int[count_neg];

                for (int i = i_minim + 1; i < i_maxim; i++)
                {
                    if (array[i] < 0)
                    {
                        negatives[j] = array[i];
                        j++;
                    }
                }
            } else
            {
                negatives = new int[0];
            }            
            
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {
            // code here
            int i_maxim = 0, i_first_neg = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[i_maxim])
                {
                    i_maxim = i;
                }
                if (array[i] < 0 && i_first_neg == -1)
                {
                    i_first_neg = i;
                }
            }

            if (i_first_neg != -1)
            {
                (array[i_maxim], array[i_first_neg]) = (array[i_first_neg], array[i_maxim]);
            }
            // end
        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int max_elem = array[0], count_max_elem = 0, j = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max_elem)
                {
                    max_elem = array[i];
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max_elem)
                {
                    count_max_elem++;
                }
            }

            answer = new int[count_max_elem];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max_elem)
                {
                    answer[j] = i;
                    j++;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here

            int max_elem = array[0], count_max_elem = 0, j = 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max_elem)
                {
                    max_elem = array[i];
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max_elem)
                {
                    count_max_elem++;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max_elem)
                {
                    array[i] += j;
                    j++;
                }
            }
            // end

        }
        public void Task7(int[] array)
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

            int cur_sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int what_to_add = array[i];
                if (array[i] == max_elem)
                {
                    array[i] = cur_sum;
                }
                cur_sum += what_to_add;
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here

            int longest = 1;
            if (array.Length >= 1)
            {
                length = 1;
            }
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                {
                    longest++;
                } else
                {
                    length = Math.Max(length, longest);
                    longest = 1;
                }
            }
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            int[] even = new int[(array.Length + 1) / 2];
            int j = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[j] = array[i];
                    j++;
                }
            }

            for (int i = 0; i < even.Length - 1; i++)
            {
                for (int k = 0; k < even.Length - 1 - i; k++)
                {
                    if (even[k] > even[k + 1])
                    {
                        (even[k], even[k + 1]) = (even[k + 1], even[k]);
                    }
                }
            }

            int kk = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    array[i] = even[kk];
                    kk++;
                }
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            int[] middle = new int[array.Length];
            for (int i = 0; i < middle.Length; i++)
            {
                middle[i] = 100000;
            }
            int k = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool presence = false;

                for (int j = 0; j < middle.Length; j++)
                {
                    if (array[i] == middle[j])
                    {
                        presence = true;
                        break;
                    }
                }

                if (!presence)
                {
                    middle[k] = array[i];
                    k++;
                }
            }

            int how_many = 0;
            for (int i = 0; i < middle.Length; i++)
            {
                if (middle[i] != 100000)
                {
                    how_many++;
                }
            }

            cleared = new int[how_many];
            int djcjdjcdj = 0;

            for (int i = 0; i < middle.Length; i++)
            {
                if (middle[i] != 100000)
                {
                    cleared[djcjdjcdj] = middle[i];
                    djcjdjcdj++;
                }
            }
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (n > 1 && a != b)
            {
                double step = (b - a) / (n - 1);
                A = new double[n];
                int amount_pos_A = 0;

                for (int i = 0; i < n; i++)
                {
                    if (i == 0)
                    {
                        A[i] = a;
                        if (a > 0)
                        {
                            amount_pos_A++;
                        }
                    }
                    else
                    {
                        A[i] = A[i - 1] + step;
                        if (A[i - 1] + step > 0)
                        {
                            amount_pos_A++;
                        }
                    }
                }

                double[] pos_A = new double[amount_pos_A];
                int j = 0;
                double summ = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] > 0)
                    {
                        pos_A[j] = A[i];
                        j++;
                        summ += A[i];
                    }
                }

                int how_many_more_arith = 0;
                for (int i = 0; i < pos_A.Length; i++)
                {
                    if (pos_A[i] > (summ / pos_A.Length))
                    {
                        how_many_more_arith++;
                    }
                }

                B = new double[how_many_more_arith];
                int k = 0;
                for (int i = 0; i < pos_A.Length; i++)
                {
                    if (pos_A[i] > (summ / pos_A.Length))
                    {
                        B[k] = pos_A[i];
                        k++;
                    }
                }
            }
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int[] real_nums = new int[dices.Length];
            int aura = 0;

            for (int i = 0; i < dices.Length; i++)
            {
                if (dices[i] - aura < 1)
                {
                    real_nums[i] = 1;
                }
                else
                {
                    real_nums[i] = dices[i] - aura;
                }

                if (dices[i] == 6)
                {
                    aura++;
                }
            }

            int his_aura = 6;
            for (int i = 0; i < real_nums.Length; i++)
            {
                if (real_nums[i] > his_aura)
                {
                    wins++;
                }

                if (his_aura != 1)
                {
                    his_aura--;
                }
            }
            // end

            return wins;

        }
    }
}
