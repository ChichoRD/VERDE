using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    private Animator _myAnimator;
    private int xAxis;
    private int yAxis;
    private Rigidbody2D rb;
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
    public void IsAttacking(bool attack)
    {
        attacking = attack;
    }
    void Start()
    {
        _myAnimator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(attacking)
        {
            if (xAxis == 0 && yAxis == 1)
            {
                _myAnimator.SetBool("Attacking", attacking);
                _myAnimator.SetInteger("xInput", xAxis);
                _myAnimator.SetInteger("yInput", yAxis);
            }
            else if (xAxis == 0 && yAxis == -1)
            {
                _myAnimator.SetBool("Attacking", attacking);
                _myAnimator.SetInteger("xInput", xAxis);
                _myAnimator.SetInteger("yInput", yAxis);
            }
            else if (xAxis == 1 && yAxis == 0)
            {
                _myAnimator.SetBool("Attacking", attacking);
                _myAnimator.SetInteger("xInput", xAxis);
                _myAnimator.SetInteger("yInput", yAxis);
            }
            else if (xAxis == -1 && yAxis == 0)
            {
                _myAnimator.SetBool("Attacking", attacking);
                _myAnimator.SetInteger("xInput", xAxis);
                _myAnimator.SetInteger("yInput", yAxis);
            }
        }
        else
        {
            if (rb.velocity.y > 0.1f)
            {
                xAxis = 0;
                yAxis = 1;
                isMooving = true;
                _myAnimator.SetBool("Attacking", attacking);
                _myAnimator.SetBool("IsMooving", isMooving);
                _myAnimator.SetInteger("xInput", xAxis);
                _myAnimator.SetInteger("yInput", yAxis);
            }
            else if (rb.velocity.y < -0.1f)
            {
                xAxis = 0;
                yAxis = -1;
                isMooving = true;
                _myAnimator.SetBool("Attacking", attacking);
                _myAnimator.SetBool("IsMooving", isMooving);
                _myAnimator.SetInteger("xInput", xAxis);
                _myAnimator.SetInteger("yInput", yAxis);
            }
            else if (rb.velocity.x > 0.1f)
            {
                xAxis = 1;
                yAxis = 0;
                isMooving = true;
                _myAnimator.SetBool("Attacking", attacking);
                _myAnimator.SetBool("IsMooving", isMooving);
                _myAnimator.SetInteger("xInput", xAxis);
                _myAnimator.SetInteger("yInput", yAxis);
            }
            else if (rb.velocity.x < -0.1f)
            {
                xAxis = -1;
                yAxis = 0;
                isMooving = true;
                _myAnimator.SetBool("Attacking", attacking);
                _myAnimator.SetBool("IsMooving", isMooving);
                _myAnimator.SetInteger("xInput", xAxis);
                _myAnimator.SetInteger("yInput", yAxis);
            }
            else
            {
                isMooving = false;
                _myAnimator.SetBool("Attacking", attacking);
                _myAnimator.SetBool("IsMooving", isMooving);
            }
        }
    }
}
