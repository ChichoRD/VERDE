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
        if(GameManager.Instance.shopInfo != null && SceneManager.GetActiveScene().name == "Overworld H0") {
            transform.position = GameManager.Instance.shopInfo.shopExit;
        }
    }

    public void ReadInput(Vector2 input) 
    {

            // Versi�n 1 con matem�ticas
            /**
            Vector2 base0 = Vector2.right;
            Vector2 base1 = Vector2.up;

            float base0Proyection = Vector3.Dot(input, base0);
            float base1Proyection = Vector3.Dot(input, base1);
            
            
            Vector2 orto = Vector2.zero;


            if (Mathf.Abs(base0Proyection) > Mathf.Abs(base1Proyection)) orto = base0 * base0Proyection;
            else orto = base1 * base1Proyection;

       
        
            rb.velocity = orto.normalized * moveSpeed;
        
        

            if(orto.magnitude > 0)
            {
                lookDirection = orto.normalized;
            }

            **/
            // Versi�n 2 con ifs

            if(rb.velocity.x != 0 && input.y != 0)
            {
               rb.velocity = new Vector2(0, input.y > 0 ? 1 : -1) * moveSpeed;
            }

            else if(rb.velocity.y != 0 && input.x != 0)
            {
               rb.velocity = new Vector2(input.x > 0 ? 1 : -1, 0) * moveSpeed;
            }

            else if(input.x != 0)
            {
               rb.velocity = new Vector2(input.x > 0 ? 1 : -1, 0) * moveSpeed;
            }
            else if(input.y != 0)
            {
               rb.velocity = new Vector2(0, input.y > 0 ? 1 : -1) * moveSpeed;
            }
            else
            {
               rb.velocity = Vector2.zero;
            }

            if(rb.velocity != Vector2.zero) {
               lookDirection = rb.velocity.normalized;
            }

            Debug.Log(lookDirection);

    }
}
