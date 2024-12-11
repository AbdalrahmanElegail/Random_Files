using System.Threading.Channels;                                           
using M = mathh.Math1;                                                     
                                                                           
namespace prog                                                             
{                                                                          
    public class Program                                                   
    {                                                                      
        static void Main(string[] args)                                    
        {



            object x = "s";                                                
            string str = x switch                                          
            {                                                              
                int i => "int",                                            
                string i when i == "t" => "tttt",                          
                string i => "string",                                      
                bool i => "bool",                                          
                double i => "fouble",                                      
                float i => "float",                                        
                _ => "noooo"                                               
            };                                                             
            Console.WriteLine(str + "\n");                                 
                                                                           
                                                                           
            Student st = new("ahmed", "samy", 21, 1011011);                
            st.greet();                                                    
            Console.WriteLine(st.ToString());                              
                                                                           
                                                                           
            Console.WriteLine();                                           
            M.Greet();                                                     
            M.PrintSumOf(5, 7);                                            
                                                                           
                                                                           
            Console.ReadKey();                                             
        }                                                                  
    }                                                                      
}                                                                          
                                                                           