class AverageSolution
{
  public static double FindAverage(double[] array)
  {
    
    int i;
    double media=0.0;
    
    for(i=0; i<array.Length; i++)
      {
          media = media + array[i];
      }
    
    media = media/array.Length;
    
    if(array.Length > 0.0)
      return media;
    
    else
      return 0;
  }
} 
