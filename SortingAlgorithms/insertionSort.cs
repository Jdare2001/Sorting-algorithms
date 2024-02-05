class InsertionSort{
    public int[] AscSort(int[] ints){
        int intsSize = ints.Length;
        for(int i = 0; i < intsSize-1; i++){
            for(int j = i +1; j > 0; j--){
                if(ints[j-1]> ints[j]){
                    int temp = ints[j-1];
                    ints[j-1] = ints[j];
                    ints[j] = temp;
                }
            }
        }



        return ints;
    }
}