using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour, IWeapon
{
    int amount; 
    
    public void Use(Vector2 posicion)
    {
        Debug.Log("Bomb Attack");

        //Checkear si bombas mayor a 0
        if (amount > 0)
        {

        }
        //Instanciar prefab de la bomba

            
        



    }
}