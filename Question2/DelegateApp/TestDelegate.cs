using System;
using System.Linq;
namespace DelegateApp
{
    public class TestDelegate
    {
        
        public string Space(string name)
        {
            string strResult = String.Join(" ", name.Reverse());
            string newSpace = "";
            for(int i = strResult.Length-1; i >= 0; i--)
            {
                newSpace += strResult[i];
            }
             return newSpace;
        }
   
   
      public string Reverse(string name)
      {
        char[] charArray = name.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);

      }

    }
}    