public class SelctionSort{
    public static int[] SimpleSelectionSort(int[] list){
        if(list.Length<=1) return list;
        for(var i=0;i<list.Length;i++){
            var min = i;
            var j = i+1;
            while(j<list.Length){
                if(list[j]<list[min]){
                    min = j;
                }
                j++;
            }
            if(min!=i){
                var t = list[i];
                list[i] = list[min];
                list[min] = t;
            }
        }
        return list;
    }
    public static int[] BinarySelectionSort(int[] list){
        var length = list.Length;
        if(length<=1) return list;
        for(var i=0;i<=length/2;i++){
            var min = i;
            var max = length - i -1;

            for(var j=i+1;j<length-i;j++){
                if(list[j]<list[min]){
                    min = j;
                }
                else if(list[j]>list[max]){
                    max = j;
                }
            }
            if(min!=i){
                var t = list[i];
                list[i] = list[min];
                list[min] = t;
            }
            if(max!=length-i-1){
                var t = list[length-i-1];
                list[length-i-1] = list[max];
                list[max] = t;
            }
        }
        return list;
    }
    public static int[] HeapSort(int[] list){
        var length = list.Length;
        if(length<=1) return list;
        //首先建立一个堆，堆顶为数组中最大的元素
        //依据2*(index+1)<=length => index <= length/2 - 1 
        for(var i= length/2 -1 ;i>=0;i--){
            HeapConstruct(list,i,length);
        }
        //倒序循环，对换堆顶到队尾，依次构造堆。
        for(var i =length-1;i>0;i--){
            var temp = list[i];
            list[i] = list[0];
            list[0] = temp;
            HeapConstruct(list,0,i);
        }
        return list;
    }
    private static void HeapConstruct(int[] list,int startIndex, int length){
        
        var currentIndex = startIndex;
        var temp = list[currentIndex];
        var leftChildIndex = (currentIndex+1)*2 -1;
        
        //循环找到左儿子是否还在值的范围内
        while(leftChildIndex<length){
            var biggerChild = leftChildIndex;
            var rightChildIndex = leftChildIndex+1;
            if(rightChildIndex < length && list[rightChildIndex]> list[leftChildIndex]){
                biggerChild = rightChildIndex;
            }
            if(temp < list[biggerChild]){               
                //如果比较大的子节点比自己大，那么互换节点的值。
                list[currentIndex] = list[biggerChild];
                list[biggerChild] = temp;
                //当前节点指向较大的那个子节点
                currentIndex = biggerChild;
                //找到较大子节点的左儿子
                leftChildIndex = (biggerChild+1)*2-1;
                temp =list[currentIndex];    
            }
            else{    
                //如果当前节点比儿子节点都大则终止循环           
                break;
            }      
        }        
    }
}