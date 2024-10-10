using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoWantsToBeAMillionaire
{
    internal class Map
    {
        char[,] map = new char[5, 5]
        {
            {'|',' ',' ',' ',' '},
            {'|',' ',' ',' ',' '},
            {'|',' ',' ',' ','|'},
            {'|','X','|',' ','|'},
            {'|',' ','|',' ','|'}
        };

        int characterRow = 0;
        int characterCol = 0;

        public void Draw()
        {
            int nRows = map.GetUpperBound(0);

            for (int row = 0; row <= nRows; row++)
            {
                //How many columns are there?
                int nColumns = map.GetUpperBound(1);

                for (int column = 0; column <= nColumns; column++)
                {
                    Console.Write(map[row,column]);
                }

                Console.Write('\n');
            }
        }
    }
}
