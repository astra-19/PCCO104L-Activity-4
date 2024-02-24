using System;

class Program {
  public static void Main (string[] args) {

    string combinedWords = "";
    int totalNum = 0;

    while (true) {
      Console.WriteLine("Enter something:  ");
      string inputWord = Console.ReadLine();

      if (inputWord.ToLower () == "exit") {
        Console.WriteLine("Closing program...");
        break;
      }
      if (int.TryParse(inputWord, out int num)) {
          totalNum += num;
      }
      else {
        combinedWords += inputWord;
      }

      Console.WriteLine($"Adding {num} = {totalNum}");
      Console.WriteLine($"Current message is: {combinedWords}");


  }
  }
  }