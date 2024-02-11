using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    #region parameters

    [SerializeField]
    private float speed = 1;

    [SerializeField]
    public bool faceMovementDirection = true;

    #endregion

    #region references

    private Rigidbody2D body;

    #endregion

    #region properties

    private Transform _myTransform;

    private Vector2 directionVector;

    public Vector2 DirectionVector
    {
        get { return directionVector; }
    }

    #endregion

    #region parameters

    public void SetDirection(Vector2 newDirection)
    {
        directionVector = newDirection.normalized;
    }

    #endregion

    private void Awake()
    {
        directionVector = Vector2.right;
    }

    void Start()
    {
        _myTransform = transform;

    //    directionVector = Vector2.right;

        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        body.velocity = directionVector * speed;
        
        if (faceMovementDirection)
        {
            _myTransform.right = directionVector;
        }
    }
}
