using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public class Block
{
    private Chunk _chunk;
    private GameObject _cube;

    public Vector3 Location;

    public Block(GameObject cube, Chunk chunk)
    {
        _cube = cube;
        _chunk = chunk;
        //Location = 
    }

}

