class InsertionSort{
    public int[] ascsort(int[] ints){
        int intsSize = ints.Length;
        for(int i = 1; i < intsSize; i++){
            int key = ints[i];
            int j = i;

            while(j >= 0 && ints[j] > key){
                ints[j+1]= ints[j];
                j = j-1;
            }
            ints[j+1] = key;
        }



        return ints;
    }
}