using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public static class ChunkHelper
{
    public static List<List<List<Block>>> GetEmptyChunkContent(Vector3 chunkPosition)
    {
        var cube = new List<List<List<Block>>>();

        for (var x = 0; x < GlobalConstants.ChunkSize; x++)
        {
            var square = new List<List<Block>>();

            for (var z = 0; z < GlobalConstants.ChunkSize; z++)
            {
                var list = new List<Block>();

                for (var y = 0; y < 3; y++)
                {
                    var position = new Vector3(x * 0.25f + chunkPosition.x,
                                               y * 0.25f + chunkPosition.y,
                                               z * 0.25f + chunkPosition.z);

                    var rotation = new Quaternion(0, 0, 0, 0);

                    list.Add(new Block(CubeFactory.Instance.GetRockBlock(position, rotation)));
                }

                for (var y = 3; y < GlobalConstants.ChunkSize - 1; y++)
                {
                    var position = new Vector3(x * 0.25f + chunkPosition.x,
                                               y * 0.25f + chunkPosition.y,
                                               z * 0.25f + chunkPosition.z);

                    var rotation = new Quaternion(0, 0, 0, 0);

                    list.Add(new Block(CubeFactory.Instance.GetDirtBlock(position, rotation)));
                }

                var positionGrass = new Vector3(x * 0.25f + chunkPosition.x,
                           (GlobalConstants.ChunkSize - 1) * 0.25f + chunkPosition.y,
                           z * 0.25f + chunkPosition.z);

                var rotationGrass = new Quaternion(0, 0, 0, 0);

                list.Add(new Block(CubeFactory.Instance.GetGrassBlock(positionGrass, rotationGrass)));

                square.Add(list);
            }

            cube.Add(square);
        }

        return cube;
    }

}
