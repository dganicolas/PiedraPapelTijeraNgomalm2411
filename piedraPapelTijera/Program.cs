// See https://aka.ms/new-console-template for more information
// creado por nicolas de gomar
class ThreadTest 
{ 

 
  static void Go() 
  { 
    Console.WriteLine ("hello!"); 
  } 
} 

  static void Main()  
  { 
    Thread t = new Thread (Go); 
 
    t.Start();   // Run Go() on the new thread. 
    Go();        // Simultaneously run Go() in the main thread. 
  } 