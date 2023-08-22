using System;
class HelloWorld {
  static void Main() {
      Console.Write("Enter a word:");
      string sentence = Console.ReadLine();
      Console.Write("Enter a sentence: ");
      string word = Console.ReadLine();
      if (word.Trim().ToUpper().Contains(sentence.Trim().ToUpper()))
      {
          Console.WriteLine(true);
      }
      else
      {
          Console.WriteLine(false);
      }
  }
}
