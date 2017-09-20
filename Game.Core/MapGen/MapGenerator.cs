using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Core.CoreGameObjects;
using UnityEngine;

namespace Game.Core.MapGen
{
    public class MapGenerator
    {

        public MapGenerator()
        {
            
        }


        public Map GetMap()
        {
            var map = new Map();

            map.Chunks.Add(new Chunk(new Vector3(0,0,0)));

            return map;
        }
    }
}
