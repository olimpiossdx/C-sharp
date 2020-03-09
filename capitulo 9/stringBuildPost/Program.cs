using System;
using stringBuildPost.Entities;
namespace stringBuildPost {
  class Program {
    static void Main (string[] args) {
      Comment c1, c2;
      Post p1, p2;

      c1 = new Comment ("Have a nice trip!");
      c2 = new Comment ("Wow that's awesome!");

      p1 = new Post (DateTime.Parse ("21/06/2018 13:05:44"), "Traveling to New Zeland", "I'm going to visit this wonderful country", 12);

      p1.AddComment (c1);
      p1.AddComment (c2);

      c1 = new Comment ("Good night");
      c2 = new Comment ("May the Force be with you");

      p2 = new Post (DateTime.Parse ("28/07/2018 23:14:49"), "Good night guys", "See you tomorrow", 5);

      p2.AddComment (c1);
      p2.AddComment (c2);

      Console.WriteLine (p1.ToString () + "\n");
      Console.WriteLine (p2.ToString ());
    }
  }
}