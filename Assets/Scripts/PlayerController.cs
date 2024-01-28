using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Sword sword;
    private float xAxis;
    private float yAxis;
    private Rigidbody2D rb;
    public float moveSpeed = 10f;
    private Vector2 direction;
    public Vector2 lookDirection;


    private void OnEnable()
    {
        sword = GetComponent<Sword>();
        rb = GetComponent<Rigidbody2D>();
        lookDirection = Vector2.down;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if (sword.attacking)
        //{
        //    direction = Vector2.zero;
        //}
        //else
        //{
        //    direction = new Vector2(xAxis, yAxis).normalized;
        //}

        //rb.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);

        //if (direction.magnitude > 0)
        //{
        //    lookDirection = direction;
        //}
        //else lookDirection = lookDirection;

    }

    public void ReadInput(Vector2 input) 
    {
        print(input);
        rb.velocity = input * moveSpeed;
    }
    
    /*private float xAxis;
   private float yAxis;
   private Vector2 direction;
   public void SetHorizontalInput(float x)
   {
       xAxis = x;
   }
   public void SetVerticalInput(float y)
   {
       yAxis = y;
   }

   // Start is called before the first frame update
   void Start()
   {
       rb = GetComponent<Rigidbody2D>();
   }

   // Update is called once per frame
   void FixedUpdate()
   {
       direction = new Vector2(xAxis, yAxis).normalized;
       rb.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);
   }*/
}
