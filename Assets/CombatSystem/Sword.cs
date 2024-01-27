using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Sword : MonoBehaviour, IWeapon
{
    int damage;
    [SerializeField]
    private Collider2D hitbox;
    public void Use(Vector2 posicion)
    {
        Debug.Log("Sword Attack");

        //Llamada al animator para cambiar de sprite

        //Llamada al character movement para que el personaje no pueda moverse durante la animacion

        //Instanciar una hitbox

                    //Collider2D collision = Physics2D.OverlapCircle(posicion, 3);
        
        hitbox.enabled = true;

        //Recibir evento de fin de animacion y desactivar hitbox
        hitbox.enabled = false;

        //Checkear si Link está con la vida al completo. Si lo está, disparar un prefab de proyectil.



    }
    void Start()
    {
        hitbox = GetComponent<Collider2D>();
    }
}