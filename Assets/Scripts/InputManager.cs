/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    // Start is called before the first frame update
    private float xInput;
    private float yInput;
    [SerializeField]
    PlayerController controller;
    // Update is called once per frame
    private void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            controller.SetVerticalInput(yInput);
            controller.SetHorizontalInput(0);
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            controller.SetHorizontalInput(xInput);
            controller.SetVerticalInput(0);
        }
        else
        {
            controller.SetHorizontalInput(0);
            controller.SetVerticalInput(0);
        }
    }
}*/
