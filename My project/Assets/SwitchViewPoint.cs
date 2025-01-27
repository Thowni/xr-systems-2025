using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SwitchViewPoint : MonoBehaviour
{
    public Transform roomPos;
    public Transform exViewPos;
    private bool inRoom = true;
    public InputActionReference action;
    // Start is called before the first frame update
    void Start()
    {
        action.action.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if(action.action.triggered)
        {
            if(inRoom)
            {
                transform.position = exViewPos.position;
            }
            else
            {
                transform.position = roomPos.position;
            }
            inRoom = !inRoom;
        }
    }
}
