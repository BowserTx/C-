public class Kata
{
    public static string UpdateLight(string current)
    {
        if(string.Equals(current, "green"))
          return "yellow";
      
        else if(string.Equals(current, "yellow"))
          return "red";
      
      
        else
          return "green";
    
      
    }
}


/*

public class Kata
{
    public static string UpdateLight(string current)
    {
        return current=="green" ? "yellow":
               current=="yellow" ? "red" : "green";
    }
}

*/
