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
    void Start()
    {
        playerAnimatorController = GetComponent<PlayerAnimatorController>();
    }

    public bool Use(Vector2 playerPosition, Vector2 playerDirection)
    {
        Debug.Log("Sword Attack");

        playerAnimatorController.onUsingItem(true, 0);

        currentHitbox =Instantiate(swordHitbox, playerPosition + playerDirection, Quaternion.identity);
        currentHitbox.GetComponent<SwordHitbox>().playerCollider = GetComponent<Collider2D>();
        currentHitbox.GetComponent<SwordHitbox>()._animatorController = GetComponent<PlayerAnimatorController>();

        //Checkear si Link está con la vida al completo. Si lo está, disparar un prefab de proyectil
        //Checkear si Link está con la vida al completo. Si lo está, disparar un prefab de proyectil.
 
        return true;
    }
}