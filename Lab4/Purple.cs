namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            /* 
            В метод передается одномерный массив array. В массиве все элементы, расположенные после
            максимального, заменить средним значением элементов массива. Если максимальный элемент
            встречается несколько раз, заменить элементы после первого максимального.
            */

            int imaxim = 0;
            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[imaxim])
                {
                    imaxim = i;
                }
                sum += array[i];
            }

            double avg = sum / array.Length;

            for (int i = imaxim + 1; i < array.Length; i++)
            {
                array[i] = avg;
            }
            // end
        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            /*
            В метод передается одномерный массив array. Сформировать два массива, включая в первый
            массив элементы исходного массива с четными индексами, во второй – с нечетными. Если
            длина исходного массива нечетная, первый выходной массив должен быть на 1 элемент
            больше второго.
            */
            odd = new int[array.Length / 2];
            if (array.Length % 2 == 0)
            {
                even = new int[array.Length / 2];
            } else
            {
                even = new int[array.Length / 2 + 1];
            }

            int ieven = 0, iodd = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[ieven] = array[i];
                    ieven++;
                } else
                {
                    odd[iodd] = array[i];
                    iodd++;
                }
            }
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            /* 
            В метод передается одномерный массив array и число P. Добавить элемент, равный Р, после
            того элемента массива, который наиболее близок к среднему значению его элементов. Если
            несколько элементов одинаково близки, выбрать первый слева.
            */
            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            double avg = sum / array.Length;
            double mindiff = 100000000;
            int imindiff = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i] - avg) < mindiff)
                {
                    mindiff = Math.Abs(array[i] - avg);
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i] - avg) == mindiff)
                {
                    imindiff = i;
                    break;
                }
            }

            answer = new int[array.Length + 1];
            int j = 0;
            for (int i = 0; i < answer.Length; i++)
            {
                if (i == imindiff + 1)
                {
                    answer[i] = P;
                } else
                {
                    answer[i] = array[j];
                    j++;
                }
            }
            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            /* 
            В метод передается одномерный массив array. Все отрицательные элементы переместить в
            конец массива с сохранением порядка их следования. Порядок положительных элементов
            также сохраняется.
            */

            int amount_pos = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    amount_pos++;
                }
            }

            int[] pos = new int[amount_pos], neg = new int[array.Length - amount_pos];
            int ipos = 0, ineg = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    pos[ipos] = array[i];
                    ipos++;
                }
                else
                {
                    neg[ineg] = array[i];
                    ineg++;
                }
            }

            for (int i = 0; i < pos.Length; i++)
            {
                array[i] = pos[i];
            }
            int k = 0;
            for (int i = pos.Length; i < pos.Length + neg.Length; i++)
            {
                array[i] = neg[k];
                k++;
            }
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            if (k < 0 || k > A.Length) return A;
            answer = new int[A.Length + B.Length];

            if (k == A.Length)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    answer[i] = A[i];
                }
                for (int i = 0; i < B.Length; i++)
                {
                    answer[A.Length + i] = B[i];
                }
            }
            else
            {
                for (int i = 0; i < k; i++)
                {
                    answer[i] = A[i];
                }
                for (int i = 0; i < B.Length; i++)
                {
                    answer[k + i] = B[i];
                }
                for (int i = k; i < A.Length; i++)
                {
                    answer[i + B.Length] = A[i];
                }
            }
            // end

            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            if (A.Length >= 1 && A.Length == B.Length)
            {
                sum = new int[A.Length];
                dif = new int[A.Length];

                for (int i = 0; i < A.Length; i++)
                {
                    sum[i] = A[i] + B[i];
                    dif[i] = A[i] - B[i];
                }
            }
            // end

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = null;

            // code here
            /*
            В метод передается одномерный массив array. Преобразовать значения массива, чтобы его
            элементы принадлежали отрезку [-1, 1]. Если все элементы массива равны, вернуть null.
            */

            double minim = array[0], maxim = array[0];
            bool all_elems_equal = true;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxim)
                {
                    maxim = array[i];
                }
                if (array[i] < minim)
                {
                    minim = array[i];
                }
                if (array[i] != array[i - 1])
                {
                    all_elems_equal = false;
                }
            }

            if (!all_elems_equal)
            {
                normalized = new double[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    normalized[i] = 2 * ((array[i] - minim) / (maxim - minim)) - 1;
                }
            }
            // end
            
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            /*
            В метод передаются одномерные массивы A и B. Отсортировать их по убыванию и слить в
            новый массив C, сохраняя упорядочение элементов.
            */
            C = new int[A.Length + B.Length];

            for (int i = 0; i < A.Length; i++)
            {
                C[i] = A[i];
            }
            for (int i = 0; i < B.Length; i++)
            {
                C[A.Length + i] = B[i];
            }

            for (int i = 0; i < C.Length - 1; i++)
            {
                for (int j = 0; j < C.Length - i - 1; j++)
                {
                    if (C[j] < C[j + 1])
                    {
                        (C[j], C[j + 1]) = (C[j + 1], C[j]);
                    }
                }
            }
            // end

            return C;
        }
        public void Task9(int[] array)
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

            int[] new_array = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                new_array[(i + imaxim) % array.Length] = array[i];
            }

            for (int i = 0; i < new_array.Length; i++)
            {
                array[i] = new_array[i];
            }
            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here
            for (int i = 0; i < N - 1; i++)
            {
                if (i + N < array.Length)
                {
                    array[N + i] = array[N - i - 2];
                }
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            double h = (b - a) / (n - 1);

            X = new double[(int)((b - a) / h) + 1];
            Y = new double[(int)((b - a) / h) + 1];

            for (int i = 0; i < X.Length; i++)
            {
                X[i] = a + i * h;
            }

            for (int i = 0; i < X.Length; i++)
            {
                Y[i] = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
            }
            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here
            double sum = 0;

            for (int i = 0; i < raw.Length; i++)
            {
                sum += raw[i];
            }

            double avg = sum / raw.Length;
            double too_bright = avg * 2;
            double too_dim = avg / 2;
            int amount_more_too_bright = 0, amount_more_too_dim = 0, amount_normal = 0;

            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > too_bright)
                {
                    amount_more_too_bright++;
                }
                else if (raw[i] < too_dim)
                {
                    amount_more_too_dim++;
                } else
                {
                    amount_normal++;
                }
            }

            bright = new double[amount_more_too_bright];
            dim = new double[amount_more_too_dim];
            normal = new double[amount_normal];
            int ibright = 0, idim = 0, inormal = 0;

            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > too_bright)
                {
                    bright[ibright] = raw[i];
                    ibright++;
                }
                else if (raw[i] < too_dim)
                {
                    dim[idim] = raw[i];
                    idim++;
                } else
                {
                    normal[inormal] = raw[i];
                    inormal++;
                }
            }

            double sum_normal = 0;

            for (int i = 0; i < normal.Length; i++)
            {
                sum_normal += normal[i];
            }

            double avg_normal = sum_normal / normal.Length;
            double[] new_dim = new double[amount_more_too_dim];
            double[] new_bright = new double[amount_more_too_bright];

            for (int i = 0; i < bright.Length; i++)
            {
                new_bright[i] = (bright[i] + avg_normal) / 2;
            }
            for (int i = 0; i < dim.Length; i++)
            {
                new_dim[i] = (dim[i] + avg_normal) / 2;
            }

            int cur_idim = 0, cur_ibright = 0;

            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > too_bright)
                {
                    raw[i] = new_bright[cur_ibright];
                    cur_ibright++;
                }
                else if (raw[i] < too_dim)
                {
                    raw[i] = new_dim[cur_idim];
                    cur_idim++;
                }
            }

            for (int i = 0; i < raw.Length - 1; i++)
            {
                for (int j = 0; j < raw.Length - 1 - i; j++)
                {
                    if (raw[j] < raw[j + 1])
                    {
                        (raw[j], raw[j + 1]) = (raw[j + 1], raw[j]);
                    }
                }
            }

            normal = new double[raw.Length];
            for (int i = 0; i < raw.Length; i++)
            {
                normal[i] = raw[i];
            }
            // end

            return (bright, normal, dim);
        }
    }
}
