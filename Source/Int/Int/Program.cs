using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int
{
   class Program
   {
      static void Main( string[] args )
      {
         int[] array = new int[101];

         for ( int index = 0; index < array.Length - 1; index++ )
         {
            array[index] = index;
         }

         array[100] = 69;



         for ( int i = 0; i < 101; i++ )
         {
            for ( int j = 0; j < 101; j++ )
            {
               if ( array[i] == array[j] )
               {
                  
               }
            }
         }
      }
   }
}
