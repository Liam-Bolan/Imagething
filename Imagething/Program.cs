using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        // The first number BitmapImage[0] is the number of horizontal pixels (stored as a string)
        // The second number  BitmapImage[1]  is the number of vertical pixels (stored as a string)
        // Each row of pixel data BitmapImage[2] - BitmapImage[9] is stored in subsequent cells
        // Each pixel is represented by 4 binary digits

        //You need to write a program to display this image in console mode
        //Then , underneath display the image size in bytes.
        //
        // TIPS
        // You need a loop to process rows and one to process each pixel inside each row.
        // PIXEL = BitmapImage[2].Substring(0,4) would get the first four binary digits of the image.
        // "1001"
        //
        // We can then conver tthat to a decimal value using int PIXELVALUE = Convert.ToInt(PIXEL,2)
        // and then to a console color using (ConsoleColor)PIXELVALUE

        // set the background to this colour and write a space
        // writeline after every row is processed like this


        static string[] BitmapImage ={"10","8","1001100110011001100110011001100110011001",
                                                  "1001111010011001100110011001111111111001",
                                                  "1001100100100010100110011111111111111111",
                                                  "1001001000100010001010011111111111111111",
                                                  "1001001000100010001010011001100110011001",
                                                  "1001100100100010100110011001100110011001",
                                                  "1001100101000100100110011001100110011001",
                                                  "0010001000100010001000100010001000100010"};



        static void Main(string[] args)
        {
            int width = int.Parse(BitmapImage[0]);
            int height = int.Parse(BitmapImage[1]);

            for (int thisrow = 0; thisrow < height; thisrow++)
            {
                for (int thiscol = 0;thiscol < width;thiscol++)
                {
                    string currentrow = (BitmapImage[2 + thisrow]);
                    string currentpixel = currentrow.Substring(thiscol * 4, 4);
                    int pixelvalue = Convert.ToInt32(currentpixel, 2);
                    Console.BackgroundColor = (ConsoleColor)pixelvalue;
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            int size = ((height * width) / 2);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(size + "bytes");
            Console.ReadLine();
            
             
            
            /* PSEUDO CODE

               get heightofimage
               get widthofimage

               for thisrow = 0 to heightofimage-1
                 for thiscolumn=0 to widthofimage-1 
                   currentrow= BitmapImage[2 + thisrow]
                   currentpixel=currentrow.substring(thiscolumn*4,4)
                   pixelvalue = int.converttoint32(currentopixel,2)
                       BackgroundColor = (ConsoleColor)pixelvalue
                       Write(" ");
                   end for
                   WriteLine
                 end for
                 size= (height * width) / 2)
                 Write(size "bytes")
                         */

        }
    }
}