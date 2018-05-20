namespace algorithm
{
    public class Radix
    {
        public static int[] RadixSort(int[] list){
            sort(list, 2);
            return list;
        }

        private static void sort(int[] list, int d){//d表示最大的数有多少位
            int k =0;
            int n =1;
            int m =1;//控制键值排序依据在哪一位
            var temp = new int[10,list.Length];//数组的第一维表示可能的余数0-9
            var order = new int[10];//数组orderp[i]用来表示该位是i的数的个数
            while(m<=d){
                //循环将数组中的值放入到相应的桶temp[lsd]中
                for(int i = 0; i < list.Length; i++)
                {
                    int lsd = ((list[i] / n) % 10);
                    temp[lsd, order[lsd]] = list[i];
                    order[lsd]++;
                }
                //将temp中的值给回list，最低位优先LSD
                for(int i = 0; i < 10; i++)
                {
                    if(order[i] != 0)
                        for(int j = 0; j < order[i]; j++)
                        {
                            list[k] = temp[i,j];
                            k++;
                        }
                    order[i] = 0;
                }
                n *= 10;
                k = 0;
                m++;
            }
        }
    }
}