using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float xAxis;
    private float yAxis;
    private Rigidbody2D rb;
    public float moveSpeed = 10f;
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
    }
}
