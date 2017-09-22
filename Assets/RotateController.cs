using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public class RotateController
{
    private KeyController UpArrowKeyController;
    private KeyController DownArrowKeyController;
    private KeyController LeftArrowKeyController;
    private KeyController RightArrowKeyController;

    private MonoBehaviour _rotateObject;

    public const float RotateSpeed = 1.0f;

    public RotateController(MonoBehaviour rotateObject)
    {
        _rotateObject = rotateObject;

        UpArrowKeyController = new KeyController(KeyCode.UpArrow);
        DownArrowKeyController = new KeyController(KeyCode.DownArrow);
        LeftArrowKeyController = new KeyController(KeyCode.LeftArrow);
        RightArrowKeyController = new KeyController(KeyCode.RightArrow);
    }

    public void Update()
    {
        UpdateKeyControllers();

        if (UpArrowKeyController.IsPress)
        {
            _rotateObject.transform.Rotate(new Vector3(-RotateSpeed, 0.0f, 0.0f));
        }

        if (DownArrowKeyController.IsPress)
        {
            _rotateObject.transform.Rotate(new Vector3(RotateSpeed, 0.0f, 0.0f));
        }

        if (LeftArrowKeyController.IsPress)
        {
            _rotateObject.transform.Rotate(new Vector3(0.0f, -RotateSpeed, 0.0f));
        }

        if (RightArrowKeyController.IsPress)
        {
            _rotateObject.transform.Rotate(new Vector3(0.0f, RotateSpeed, 0.0f));
        }
    }

    private void UpdateKeyControllers()
    {
        UpArrowKeyController.Update();
        DownArrowKeyController.Update();
        LeftArrowKeyController.Update();
        RightArrowKeyController.Update();
    }
}

