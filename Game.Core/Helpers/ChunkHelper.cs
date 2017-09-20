using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Core.CoreGameObjects;
using UnityEngine;

namespace Game.Core.Helpers
{
    public static class ChunkHelper
    {
        public static List<List<List<Block>>> GetEmptyChunkContent(Vector3 chunkPosition)
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
                        var position = new Vector3(i * 0.25f + chunkPosition.x,
                                                   j * 0.25f + chunkPosition.y,
                                                   k * 0.25f + chunkPosition.z);
                        
                        var rotation = new Quaternion(0, 0, 0, 0);

                        list.Add(new Block(CubeFactory.Instance.GetDirtBlock(position, rotation)));
                    }

                    square.Add(list);
                }

                cube.Add(square);
            }

            return cube;
        }

    }
}
