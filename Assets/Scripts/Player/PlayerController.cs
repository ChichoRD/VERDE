using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 10f;
    public Vector2 lookDirection;


    private void OnEnable()
    {
        rb = GetComponent<Rigidbody2D>();
        lookDirection = Vector2.down;
    }

    private void Start() {
        if(GameManager.Instance.shopExit != Vector3.zero && SceneManager.GetActiveScene().name == "Overworld") {
            transform.position = GameManager.Instance.shopExit;
            GameManager.Instance.shopExit = Vector3.zero;
        }
    }

    public void ReadInput(Vector2 input) 
    {
        rb.velocity = input * moveSpeed;

        if (input != Vector2.zero)
            lookDirection = input;
    }
}
