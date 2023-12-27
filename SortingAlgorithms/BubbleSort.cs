

public class BubbleSort
{

    public int[] AscendingSort(int[] ints){

        bool changeMade = true;

        while(changeMade){
            changeMade = false;
            for(int i = 0; i < ints.Length-1; i++){
                if(ints[i] > ints[i+1]){
                    int temp = ints[i+1];
                    ints[i+1] = ints[i];
                    ints[i] = temp;
                    changeMade = true;
                }

            }
        }

        return ints;

    }
    public int[] DescendingSort(int[] ints){

        bool changeMade = true;

        while(changeMade){
            changeMade = false;
            for(int i = 0; i < ints.Length-1; i++){
                if(ints[i] < ints[i+1]){
                    int temp = ints[i+1];
                    ints[i+1] = ints[i];
                    ints[i] = temp;
                    changeMade = true;
                }

            }
        }

        return ints;

    }
    
}