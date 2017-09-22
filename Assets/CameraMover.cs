using UnityEngine;
using System.Collections;

public class CameraMover : MonoBehaviour
{
    private MoveController _moveController;
    private RotateController _rotateController;
    
    // Use this for initialization
    void Start()
    {
        _moveController = new MoveController(this);
        _rotateController = new RotateController(this);
    }

    // Update is called once per frame
    void Update()
    {
        _moveController.Update();
        _rotateController.Update();
    }
}
