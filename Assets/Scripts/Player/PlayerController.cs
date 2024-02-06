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

        if(rb != null) {

            if (rb.velocity.x != 0 && input.y != 0) {
                rb.velocity = new Vector2(0, input.y > 0 ? 1 : -1) * moveSpeed;
            } else if (rb.velocity.y != 0 && input.x != 0) {
                rb.velocity = new Vector2(input.x > 0 ? 1 : -1, 0) * moveSpeed;
            } else if (input.x != 0) {
                rb.velocity = new Vector2(input.x > 0 ? 1 : -1, 0) * moveSpeed;
            } else if (input.y != 0) {
                rb.velocity = new Vector2(0, input.y > 0 ? 1 : -1) * moveSpeed;
            } else {
                rb.velocity = Vector2.zero;
            }

            if (rb.velocity != Vector2.zero) {
                lookDirection = rb.velocity.normalized;
            }

            Debug.Log(lookDirection);

        }

            

    }
}
