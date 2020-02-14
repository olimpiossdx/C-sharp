using System;

namespace funcaoInteressanteParaString {
  class Program {
    static void Main (string[] args) {
      string original = "abcde  FGHIJ ABC abc DEFG  ";
      string s1 = original.ToUpper ();

      Console.WriteLine ($"Original:  {original}\n");

      Console.WriteLine ("Checklist\n");
      Console.WriteLine (".Formatar: ToLower(), ToUpper(), Trim()");
      Console.WriteLine ($"ToUpper():  -{s1}-");
      string s2 = original.ToLower ();
      Console.WriteLine ($"ToLower():  -{s2}-");
      string s3 = original.Trim ();
      Console.WriteLine ($"Trim():     -{s3}-\n");

      Console.WriteLine (".Buscar:  IndexOf,LastIndexOf");
      int n1 = s1.IndexOf ("bc");
      Console.WriteLine ($"IndexOf():     {n1}");
      int n2 = s1.LastIndexOf ("bc");
      Console.WriteLine ($"LastIndexOf(): {n2}\n");

      Console.WriteLine (".Recortar:Substring(inicio),Substring(inicio,tamanho)");
      string s4 = original.Substring (3);
      Console.WriteLine ($"Substring(3): {s4}");
      string s5 = original.Substring (3, 5);
      Console.WriteLine ($"Substring(3,5): {s5}\n");

      Console.WriteLine (".Substituir: Replace(char,char), Replace(string,string)");
      string s6 = original.Replace ('a', 'x');
      Console.WriteLine ($"Replace('a','x'): {s6}");
      string s7 = original.Replace ("abc", "xy");
      Console.WriteLine ($"Replace('abc','xy'): {s7}\n");

      Console.WriteLine (".String.IsNullOrEmpty,String.IsNullOrWhiteSpace");
      bool b1 = string.IsNullOrEmpty (original);
      Console.WriteLine ($"String.IsNullOrEmpty: {b1}");
      bool b2 = string.IsNullOrWhiteSpace (original);
      Console.WriteLine ($"String.IsNullOrWhiteSpace: {b2}\n");

      Console.WriteLine (".str.Split('')");
      string[] s8 = original.Split (' ');
      Console.Write ("Split(): ");
      for (int i = 0; i < s8.Length; i++)
        Console.Write (" " + s8[i]);

      Console.WriteLine ('\n');

      Console.WriteLine (".Conversão para número: int x = int.Parse(str),  int x = Convert.ToInt32(str)");
      Console.WriteLine ($".int.Parse(str): {int.Parse(original)}");
      Console.WriteLine ($".Convert.ToInt32(str): {Convert.ToInt32(original)}\n");

      Console.WriteLine (".Conversão de número: str = x.toString(), str= x.ToString('C'),\nstr= x.ToString(C3), str= x.ToString('F2')");
      Console.WriteLine ($"x.toString(): {10.ToString()}");
      Console.WriteLine ($"x.ToString('C'): {10.ToString("C")}");
      Console.WriteLine ($"x.ToString('C3'): {10.ToString("C3")}");
      Console.WriteLine ($"x.ToString('F2'): {10.ToString("F2")}");
    }
  }
}