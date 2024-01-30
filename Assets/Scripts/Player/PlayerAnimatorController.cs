using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    private Animator _myAnimator;
    private int xAxis;
    private int yAxis;
    private bool isMooving;

    //Recibe booleano en animator de si esta usando una accion
    public void onUsingItem(bool boolean, int actionType)
    {
        if (actionType == 0) //SI ACTIONTYPE ES 0, ANIMACION DE USAR ITEM
        {
            _myAnimator.SetBool("IsAttacking", boolean);
        }
        else if (actionType == 1) //SI ACTIONTYPE ES 1, ANIMACION DE USAR ITEM
        {
            _myAnimator.SetBool("IsUsingItem", boolean);
        }

        Debug.Log(boolean + " "+actionType);
        
    }

    // Start is called before the first frame update
    void Start()
    {
        _myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            xAxis = 0;
            yAxis = 1;
            isMooving = true;
            _myAnimator.SetBool("IsMooving", isMooving);
            _myAnimator.SetInteger("xInput", xAxis);
            _myAnimator.SetInteger("yInput", yAxis);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            xAxis = 0;
            yAxis = -1;
            isMooving = true;
            _myAnimator.SetBool("IsMooving", isMooving);
            _myAnimator.SetInteger("xInput", xAxis);
            _myAnimator.SetInteger("yInput", yAxis);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            xAxis = 1;
            yAxis = 0;
            isMooving = true;
            _myAnimator.SetBool("IsMooving", isMooving);
            _myAnimator.SetInteger("xInput", xAxis);
            _myAnimator.SetInteger("yInput", yAxis);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            xAxis = -1;
            yAxis = 0;
            isMooving = true;
            _myAnimator.SetBool("IsMooving", isMooving);
            _myAnimator.SetInteger("xInput", xAxis);
            _myAnimator.SetInteger("yInput", yAxis);
        }
        else
        {
            isMooving = false;
            _myAnimator.SetBool("IsMooving", isMooving);
        }
    }
}
