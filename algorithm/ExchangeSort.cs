public class ExchangeSort{
    public static int[] SimpleBubbleSort(int[] list){
        var length = list?.Length;
        if(length<=1) return list;
        for(var i=0;i<length;i++){
            //从第0个元素开始，到倒数第二个元素，依次对比冒泡。
            for(var j=0;j<length-1-i;j++){
                if(list[j]>list[j+1]){
                var temp = list[j];
                list[j]=list[j+1];
                list[j+1]=temp;
                }
            }          
        }
        return list;
    } 

    public static int[] BubbleWithFlagSort(int[] list){
        var length = list?.Length;
        if(length<=1) return list;
        int i = (int)length-1;
        while(i>0){
            int pos = 0;
            for(var j=0;j<i;j++){
                if(list[j]>list[j+1]){
                    pos = j;
                    var temp = list[j];
                    list[j]=list[j+1];
                    list[j+1]=temp;
                }
            }
            i = pos;
        }       
        return list;
    }

    public static int[] BubbleTwoSidesSort(int[] list){
        var length = list?.Length;
        if(length<=1) return list;
        int low =0;
        int high = (int)length-1;
        while(low<high){           
            for(var j=low;j<high;j++){
                if(list[j]>list[j+1]){
                    var temp = list[j];
                    list[j]=list[j+1];
                    list[j+1]=temp;
                }                             
            }
            high--;
            for(var j=high;j>low;j--){
                if(list[j]<list[j-1]){
                    var temp = list[j];
                    list[j]=list[j-1];
                    list[j-1]=temp;
                }
            }
            low++;
        }       
        return list;
    }

    public static int[] QuickSort(int[] list){
        var length = list?.Length;
        if(length<=1) return list;
        QuickSort(list,0,(int)length-1);
        return list;
    }

    private static void QuickSort(int[] list, int low, int high){
        if(low<high){
            int privotIndex = Partition(list, low, high);
            QuickSort(list, low, privotIndex -1);
            QuickSort(list, privotIndex+1, high);
        }
    }
    private static int Partition(int[] list,int low,int high){
        var pivot = list[low];
        while(low<high){
            //从高到低，跳过本来就比标的值大的
            while(low<high&&list[high]>=pivot) high--;
            //交换比标的值小的
            var temp1 = list[low];
            list[low]=list[high];
            list[high]=temp1;
            //从低到高，跳过本来就比标的值小的
            while(low<high&&list[low]<=pivot) low++;
            //交换比标的大的
            var temp2 = list[low];
            list[low]=list[high];
            list[high]=temp2;
        }
        return low;
    }

    public static int[] ImprovedQuickSort(int[] list){
        var length = list?.Length;
        if(length<=1) return list;
        //对子序列大于8个元素时才进行快速排序,实验证明8的时候性能最佳
        QuickSort(list,0,(int)length-1,8);
        //对快速排序后的序列进行插入排序
        for(var i=1;i<length;i++){
            int tmp = list[i];
            int j = i-1;
            while(j>=0&&tmp<list[j]){
                list[j+1]=list[j];
                j--;
            }
            list[j+1] = tmp;
        }
        return list;
    }

    private static void QuickSort(int[] list, int low, int high, int k){
        if(high - low > k){
            int privotIndex = Partition(list, low, high);
            QuickSort(list, low, privotIndex -1);
            QuickSort(list, privotIndex+1, high);
        }
    }
}