using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    InputActionAsset playerActionMap;

    //[SerializeField] MovementController characaterController;
    PlayerInput playerInput;

    [SerializeField] PlayerController playerController;
    WeaponHandler weaponHandler;

    [SerializeField]
    private InputActionReference _movementActionReference;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        weaponHandler = playerController.GetComponent<WeaponHandler>();
    }

    private void OnEnable()
    {
        _movementActionReference.action.Enable();
    }

    private void OnDisable()
    {
        _movementActionReference.action.Disable();
    }

    private void FixedUpdate()
    {
        playerController.ReadInput(_movementActionReference.action.ReadValue<Vector2>());
    }

    public void ActionA(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            weaponHandler.AAction(playerController.lookDirection);
        }  
    }

    public void ActionB(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            weaponHandler.BAction(playerController.lookDirection);
        }
    }

    void OnStateChange(GameState state)
    {
        switch (state)
        {
            case GameState.Playing:
                playerInput.enabled = true;
                break;
            case GameState.Paused:
                playerInput.enabled = false;
                break;
            case GameState.GameOver:
                playerInput.enabled = false;
                break;
        }
    }

    void EnableInput(){
        playerActionMap.Enable();
    }

    void Start(){
        Invoke("EnableInput",0.1f);
    }
}
