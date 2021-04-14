namespace Solution
{
    static class Kata
    {
        public static bool SpeakEnglish(string sentence)
        {
          
            if (sentence.ToLower().Contains("english"))
                return true;
            else
                return false;

 

        }
    }
}