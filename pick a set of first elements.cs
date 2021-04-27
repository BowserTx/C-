public class Kata
{
  public static object[] TakeFirstElements(object[] array, int n = 1)
  {
    if(n > array.Length)
      n = array.Length;
    var arr = new object[n];
    
    
    
    for(int i=0; i < n; i++)
      
      {
          arr[i] = array[i];
      }
    
    return arr;
  }
}
