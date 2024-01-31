using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Sword : MonoBehaviour, IWeapon
{
   
    [SerializeField]
    private GameObject swordHitbox;
    private GameObject currentHitbox;
    private PlayerAnimatorController playerAnimatorController;

    private bool _attacking;
    public bool attacking
    {
        get
        {
            return _attacking;
        }
        set
        {
            _attacking = value;
            playerAnimatorController.IsAttacking(value);
        }
    } //cooldown de atacar. EL ANIMATOR ACCEDE A ESTA VARIABLE PARA COMPROBAR SI ESTA ATACANDO O NO
    void Start()
    {
        playerAnimatorController = GetComponent<PlayerAnimatorController>();
    }
    public void Use(Vector2 playerPosition, Vector2 playerDirection)
    PlayerAnimatorController playerAnimatorController;


    public bool Use(Vector2 playerPosition, Vector2 playerDirection)
    {
        Debug.Log("Sword Attack");

        playerAnimatorController.onUsingItem(true, 0);

            currentHitbox =Instantiate(swordHitbox, playerPosition + playerDirection, Quaternion.identity);
            currentHitbox.GetComponent<SwordHitbox>().playerCollider = GetComponent<Collider2D>();
        currentHitbox.GetComponent<SwordHitbox>()._animatorController = GetComponent<PlayerAnimatorController>();

            //Checkear si Link está con la vida al completo. Si lo está, disparar un prefab de proyectil.
        }
        //Checkear si Link está con la vida al completo. Si lo está, disparar un prefab de proyectil.

        return true;
    }
    private void Start()
    {
        playerAnimatorController = GetComponent<PlayerAnimatorController>();
    }
}