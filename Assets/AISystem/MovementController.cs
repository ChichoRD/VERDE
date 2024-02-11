using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speed = 10f;
    [SerializeField] Vector2 _lookDirection = new Vector2(0, -1);
    public Vector2 lookDirection => _lookDirection;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 direction)
    {
        rb.velocity = direction * speed;
        if(direction != Vector2.zero) _lookDirection = direction;
    }

    public void MoveTowards(Vector2 target, int multiplier)
    {
        Vector2 direction = target - (Vector2)transform.position;
        Move(direction.normalized * multiplier);
    }
}
