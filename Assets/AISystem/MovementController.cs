using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MovementController : MonoBehaviour
{
    Rigidbody2D rb;
    public Rigidbody2D Rb => rb;
    [SerializeField] float speed = 10f;
    public float Speed => speed;
    [SerializeField] Vector2 _lookDirection = new Vector2(0, -1);

    public Vector2 lookDirection
    {
        get => _lookDirection;

        set
        {
            _lookDirection = value;
            if (value.x > 0) OnLookRight.Invoke();
            if (value.x < 0) OnLookLeft.Invoke();
            if (value.y > 0) OnLookUp.Invoke();
            if (value.y < 0) OnLookDown.Invoke();
        }
    }

    [SerializeField] UnityEvent OnLookRight = new UnityEvent();
    [SerializeField] UnityEvent OnLookLeft = new UnityEvent();
    [SerializeField] UnityEvent OnLookUp = new UnityEvent();
    [SerializeField] UnityEvent OnLookDown = new UnityEvent();

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 direction)
    {
        rb.velocity = direction * speed;
        if(direction != Vector2.zero) lookDirection = direction;
    }

    public void MoveTowards(Vector2 target, int multiplier)
    {
        Vector2 direction = target - (Vector2)transform.position;
        Move(direction.normalized * multiplier);
    }
}
