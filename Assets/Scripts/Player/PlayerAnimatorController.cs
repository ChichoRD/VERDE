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
    // Start is called before the first frame update
    void Start()
    {
        _myAnimator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.y > 0.1f)
        {
            xAxis = 0;
            yAxis = 1;
            isMooving = true;
            _myAnimator.SetBool("IsMooving", isMooving);
            _myAnimator.SetInteger("xInput", xAxis);
            _myAnimator.SetInteger("yInput", yAxis);
        }
        else if (rb.velocity.y < -0.1f)
        {
            xAxis = 0;
            yAxis = -1;
            isMooving = true;
            _myAnimator.SetBool("IsMooving", isMooving);
            _myAnimator.SetInteger("xInput", xAxis);
            _myAnimator.SetInteger("yInput", yAxis);
        }
        else if(rb.velocity.x > 0.1f)
        {
            xAxis = 1;
            yAxis = 0;
            isMooving = true;
            _myAnimator.SetBool("IsMooving", isMooving);
            _myAnimator.SetInteger("xInput", xAxis);
            _myAnimator.SetInteger("yInput", yAxis);
        }
        else if(rb.velocity.x < -0.1f)
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
