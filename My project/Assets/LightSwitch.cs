using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    public Light light;
    public InputActionReference action;
    void Start()
    {
        light = GetComponent<Light>();
        action.action.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if(action.action.triggered)
        {
            light.color = new Color(1, 0, 1, 1);
        }
    }
}
