using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public class Map
    {
        public List<Chunk> Chunks { get; private set; }

        public Map()
        {
            Chunks = new List<Chunk>();
        }
    }

