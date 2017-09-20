using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Core.CoreGameObjects;

namespace Game.Core.Helpers
{
    public static class ChunkHelper
    {
        public static List<List<List<Block>>> GetEmptyChunkContent()
        {
            var cube = new List<List<List<Block>>>();

            for (var i = 0; i < 8; i++)
            {
                var square = new List<List<Block>>();

                for (var j = 0; j < 8; j++)
                {
                    var list = new List<Block>();

                    for (var k = 0; k < 8; k++)
                    {
                        list.Add(new Block());
                    }

                    square.Add(list);
                }

                cube.Add(square);
            }

            return cube;
        }

    }
}
