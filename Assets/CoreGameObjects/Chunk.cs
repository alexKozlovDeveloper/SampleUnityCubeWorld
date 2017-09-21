﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public class Chunk
{
    public Vector3 Location { get; private set; }

    public List<List<List<Block>>> Content { get; private set; }

    public List<Block> ContentInRow
    {
        get
        {
            var result = new List<Block>();

            foreach (var square in Content)
            {
                foreach (var list in square)
                {
                    result.AddRange(list);
                }
            }

            return result;
        }
    }

    public Chunk(Vector3 location)
    {
        Location = location;
        Content = ChunkHelper.GetDefaultChunkContent(Location, this);
    }
}

