using System;
class HelloWorld {
  static void Main() {
      string text = "NICAT";
      string newText = text.Replace("c","d");
      string newText2 = text.Substring(2);
      string newText3 = text.ToLower();
      bool newText = text.Contains("cat");
      bool newText = text.ToUpper().Contains("CAT");
      string text = " salam hesen necesen";
      string words = text.Split(' ');
      foreach ( string word in words)
      {
          Console.WriteLine(word);
      }
      
      StringBuilder sb = new StringBuilder();
      for ( int i = 0;i<sb.Length;i++)
      {
          Console.WriteLine(sb)
      }
     
  }
}
