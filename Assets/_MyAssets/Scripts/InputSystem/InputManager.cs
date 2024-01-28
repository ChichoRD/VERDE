using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    //[SerializeField] MovementController characaterController;
    PlayerInput playerInput;

    [SerializeField] PlayerController playerController;
    WeaponHandler weaponHandler;

    private void Awake() {
        playerInput = GetComponent<PlayerInput>();
        weaponHandler = playerController.GetComponent<WeaponHandler>();
    }

    public void ActionA(InputAction.CallbackContext context)
    {
        weaponHandler.AAction(playerController.lookDirection);
    }

    public void ActionB(InputAction.CallbackContext context)
    {
        weaponHandler.BAction(playerController.lookDirection);
    }

    public void Movement(InputAction.CallbackContext context)
    {
        playerController.ReadInput(context.ReadValue<Vector2>());
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
}
