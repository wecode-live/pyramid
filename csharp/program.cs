using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for full pyramid OR 0 for half pyramid");
            int response = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height of the pyramid. e.g 20");
            int pyramidHeight = int.Parse(Console.ReadLine());
            
            switch (response)
            {
                case 1:
                    FullPyramid(pyramidHeight);
                    break;
                case 0:
                    HalfPyramid(pyramidHeight);
                    break;
                default:
                    break;
            }
        }

        static void HalfPyramid(int height)
        {
              string layer = "*";
              for(int i = 1; i < height; i++)
              {
                  Console.WriteLine(layer);   
                  layer += "*";
                        
              }
        }

        static void FullPyramid(int height)
        {
            string layer = "#";
            for (int i = 1; i < height + 1; i++)
            {               
                Console.WriteLine(layer.PadLeft(height + i)); //pads to the left with the height of the pyramid. 
                layer += "##"; //to provides a good base for the pyramid else you end up with a half pyramid 
            }
        }
    }
}
