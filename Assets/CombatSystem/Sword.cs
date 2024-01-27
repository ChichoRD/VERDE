using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Sword : MonoBehaviour, IWeapon
{
    int damage;
    [SerializeField]
    private Collider2D hitbox;

    public void SwordFinish()
    {
        Destroy(hitbox);
    }

    public void Use(Vector2 playerPosition, Vector2 playerDirection)
    {
        Debug.Log("Sword Attack");

        //Instanciar una hitbox

                    //Collider2D collision = Physics2D.OverlapCircle(posicion, 3);
        Instantiate(hitbox, playerPosition + playerDirection, Quaternion.LookRotation(playerDirection));

        //Recibir evento de fin de animacion y desactivar hitbox

        //Checkear si Link está con la vida al completo. Si lo está, disparar un prefab de proyectil.



    }
    void Start()
    {

    }
}