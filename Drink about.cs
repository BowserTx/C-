public class Kata
{
  public static string PeopleWithAgeDrink(int old)
  {
    if(old < 14)
      return "drink toddy";
    
    else if(old >=14 && old <18)
      return "drink coke";
    
    else if(old >=18 && old <21)
      return "drink beer";
    
    else
      return "drink whisky";
    
  }
}

/*
public class Kata
{
  public static string PeopleWithAgeDrink(int old)
  {
    return "drink " + (old < 14 ? "toddy" : old < 18 ? "coke" : old < 21 ? "beer" : "whisky");
  }
}

*/
