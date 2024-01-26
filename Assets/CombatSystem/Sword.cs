using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour, IWeapon
{
    int damage;
    public void Use(Vector2 posicion)
    {
        Debug.Log("Sword Attack");

        //Llamada al animator para cambiar de sprite

        //Llamada al character movement para que el personaje no pueda moverse durante la animacion

        //Instanciar un collider/trigger, con el cual se interactua en otro script.
        Collider2D collision = Physics2D.OverlapCircle(posicion, 3);

        if (collision.TryGetComponent<Health>(out Health health))
        {
            health.Damaged(damage);
        }
        
        //Borrar el trigger al terminar la animacion

        //Checkear si Link está con la vida al completo. Si lo está, disparar un prefab de proyectil.



    }
}