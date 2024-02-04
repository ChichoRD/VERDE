using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    //[SerializeField] MovementController characaterController;
    [SerializeField] PlayerInput playerInput;

    private void Awake() {
        playerInput = GetComponent<PlayerInput>();
    }

    public void ActionA()
    {
        Debug.Log("Action A");
    }

    public void ActionB()
    {
        Debug.Log("Action B");
    }

    public void Movement(InputAction.CallbackContext context)
    {
        context.ReadValue<Vector2>();
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
