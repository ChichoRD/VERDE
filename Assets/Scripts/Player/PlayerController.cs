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
    [SerializeField] private InputManager _playerInput;

    private float timer = 0;
    [SerializeField] private float knockbackTime = 0.5f;
    [SerializeField] private float knockbackSpeed = 1f;

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

    public void KnockBack()
    {
        _playerInput.enabled = false;
        rb.velocity = lookDirection * knockbackSpeed;
    }

    private void Update()
    {
        if (_playerInput.enabled==false) 
        { 
            timer = timer + Time.deltaTime;
            if (timer > knockbackTime)
            {
                timer = 0f; //reicincio del contador
                _playerInput.enabled = true;
            }
        }
    }
}
