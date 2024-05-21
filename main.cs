using System;

class Program {
  public static void Main (string[] args) {
    const double
    CM_TO_IN = 2.54;
    
    var inch = 15994;
    
    
    var Math = CM_TO_IN * inch;
    Console.WriteLine ("{0} inches", inch);
    Console.WriteLine ("{0} centimetes", Math);
  }
}