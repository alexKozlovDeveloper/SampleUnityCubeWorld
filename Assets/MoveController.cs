using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public class MoveController
{
    private KeyController WKeyController;
    private KeyController AKeyController;
    private KeyController SKeyController;
    private KeyController DKeyController;

    private MonoBehaviour _movingobject;

    public const float MovingSpeed = 0.07f;

    public MoveController(MonoBehaviour movingobject)
    {
        _movingobject = movingobject;

        WKeyController = new KeyController(KeyCode.W);
        AKeyController = new KeyController(KeyCode.A);
        SKeyController = new KeyController(KeyCode.S);
        DKeyController = new KeyController(KeyCode.D);
    }

    public void Update()
    {
        UpdateKeyControllers();

        if (WKeyController.IsPress)
        {
            _movingobject.transform.Translate(new Vector3(0.0f, 0.0f, MovingSpeed));
        }

        if (AKeyController.IsPress)
        {
            _movingobject.transform.Translate(new Vector3(-MovingSpeed, 0.0f, 0.0f));
        }

        if (SKeyController.IsPress)
        {
            _movingobject.transform.Translate(new Vector3(0.0f, 0.0f, -MovingSpeed));
        }

        if (DKeyController.IsPress)
        {
            _movingobject.transform.Translate(new Vector3(MovingSpeed, 0.0f, 0.0f));
        }
    }

    private void UpdateKeyControllers()
    {
        WKeyController.Update();
        AKeyController.Update();
        SKeyController.Update();
        DKeyController.Update();
    }

}

