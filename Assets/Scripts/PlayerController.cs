using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private InputActionAsset playerInput;
    private Rigidbody2D rb;
    [SerializeField] private float moveSpeed = 10f;
    private InputAction moveInput ;
    void Start() //Awake()
    {
        playerInput = GetComponent<InputActionAsset>();
        rb = GetComponent<Rigidbody2D>();

    }

    private void OnEnable()
    {
        playerInput.Enable();
    }
    private void OnDisable()
    {
        playerInput.Disable();
    }


    void FixedUpdate()
    {
        //Vector2 moveInput = playerInput.PlayerMovement.Move.ReadValue<Vector2>();
        var map = playerInput.FindActionMap("PlayerMovement");
        moveInput = map.FindAction("Move");
        moveInput.performed += ReadInput;
        moveInput.canceled += ReadInput;
        
    }
    private void ReadInput(InputAction.CallbackContext context) 
    { 
        var input = context.ReadValue<Vector2>();
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
