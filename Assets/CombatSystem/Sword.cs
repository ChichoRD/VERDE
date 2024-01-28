using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Sword : MonoBehaviour, IWeapon
{
   
    [SerializeField]
    private GameObject swordHitbox;
    private GameObject currentHitbox;
    

    public bool attacking = false; //cooldown de atacar. EL ANIMATOR ACCEDE A ESTA VARIABLE PARA COMPROBAR SI ESTA ATACANDO O NO

    public void Use(Vector2 playerPosition, Vector2 playerDirection)
    {
        Debug.Log("Sword Attack");

        
        if(!attacking) //si no esta atacando, puedes atacar
        {
            //llamada al animator
            attacking = true;
            currentHitbox =Instantiate(swordHitbox, playerPosition + playerDirection, Quaternion.identity);
            currentHitbox.GetComponent<SwordHitbox>().playerCollider = GetComponent<Collider2D>();
            currentHitbox.GetComponent<SwordHitbox>().referencedSword = this;

            //Checkear si Link está con la vida al completo. Si lo está, disparar un prefab de proyectil.
        }

    }
   
}