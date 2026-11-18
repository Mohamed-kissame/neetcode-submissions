public class DynamicArray {

     int [] _arr;
     int _capacity;
     int capacity => _capacity;
     int _count;
     int size => _count;

    
    
    public DynamicArray(int capacity) {

        if(capacity < 0)  throw new ArgumentOutOfRangeException(nameof(capacity), "capacity cannot be negative.");
         
         _capacity = capacity;

        _arr = new int[capacity];

        _count = 0;

    }

    public int Get(int i) {

          return _arr[i];

    }

    public void Set(int i, int n) {
         
         if(i >= size)  throw new ArgumentOutOfRangeException(nameof(i), "the index cannot be greater than the size of the array.");

         _arr[i] = n;
    }

    public void PushBack(int n) {
        
        if(capacity == size){

            Resize();
        }

         _arr[_count] = n;
         _count++;
    }

  

    public int PopBack(){

        var lastitem = _arr[_count -1];
        

        _count--;
        
        return lastitem;
    }

    private int[] CopyItems(int[]arr1)
        {

            for (int i = 0; i < _count; i++)
            {

                arr1[i] = _arr[i];

            }


            return arr1;


        }
    
    private void Resize() {
        
           _capacity *= 2;

            int[] newArray = new int[_capacity];

            newArray = CopyItems(newArray);

            _arr = newArray;
    }

    public int GetSize() {
          
          return size;
    }

    public int GetCapacity() {
         return capacity;
    }
}

