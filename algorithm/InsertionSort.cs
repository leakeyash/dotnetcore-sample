public class InsertionSort{
    public static int[] InsertSort(int[] list){
        if(list.Length<=1) return list;
        for(var i=1;i<list.Length;i++){
            if(list[i]<list[i-1]){
                var temp = list[i];
                var j = i-1;
                while(j>=0 && temp<list[j]){
                    list[j+1]= list[j];
                    j--;
                }
                list[j+1]=temp;
            }
        }
        return list;
    }

    public static int[] ShellSort(int[] list){
        int length = list.Length;
        if(length<=1) return list;
        int gap = length/2;
        while(gap>=1){
            for(var i=gap;i<length;i++){
                if(list[i]<list[i-gap]){
                    var temp = list[i];
                    var j = i-gap;
                    while(j>=0&&temp<list[j]){
                        list[j+gap] = list[j];
                        j=j-gap;
                    }
                    list[j+gap]=temp;
                }
            }
            gap = gap/2;
        }
        return list;
    }
    public static int[] BinaryInsertSort(int[] list){
        int length = list.Length;
        if(length<=1) return list;
        for(var i=1;i<length;i++){
            var temp = list[i];
            var head = 0;
            var tail = i-1;
            while(head<=tail){
                var mid = (head+tail)/2;
                if(temp< list[mid]){
                    tail = mid - 1;
                }
                else{
                    head = mid +1;
                }
            }
            for(var j = i-1;j>=head;j--){
                list[j+1]=list[j];
            }
            list[head] = temp;
        }
        return list;
    }
}