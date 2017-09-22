using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public class KeyController
{
    public KeyCode Key { get; private set; }

    public bool IsPress { get; private set; }

    public KeyController(KeyCode key)
    {
        Key = key;

        IsPress = false;
    }

    public void Update()
    {
        if (Input.GetKeyDown(Key))
        {
            IsPress = true;
        }

        if (Input.GetKeyUp(Key))
        {
            IsPress = false;
        }
    }
}

