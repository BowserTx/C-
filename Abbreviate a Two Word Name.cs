public class Kata
{
  public static string AbbrevName(string name)
  {
    int i=0;
    char first = char.ToUpper(name[i]);
    i = name.IndexOf(' ');
    //char lastname=name[i+1];
   
    return first+"."+ char.ToUpper(name[i+1]);
  }
}
