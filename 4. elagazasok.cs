using System;

namespace elgazasok{
    class Program{
        public static void Main(){
            //if
            int a = 1;
            int b = 2;

            if(a < b){
                Console.WriteLine("A kisebb");
            }

            if(a == b){
                Console.WriteLine("Egyenloek");
            }

            if(a > b){
                Console.WriteLine("A nagyobb");
            }

            // else if
            if(a > b){
                Console.WriteLine("A nagyobb");
            }else if(a == b){
                Console.WriteLine("Egyenloek");
            }else{ // a < b
                Console.WriteLine("A kisebb");
            }

            //switch case
            string be = "alma";

            switch(be){
                case "banan":
                    Console.WriteLine("Banana");
                    break;
                
                case "alma":
                    Console.WriteLine("Apple");
                    break;

                case "pite":
                    Console.WriteLine("Pie");
                    break;
            }
        }
    }
}