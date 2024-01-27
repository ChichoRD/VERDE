using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour, IWeapon
{
    int amount;
    [SerializeField]
    GameObject bombPrefab;
    
    public void Use(Vector2 posicion)
    {
        Debug.Log("Bomb Attack");

        //Checkear si bombas mayor a 0
        if (amount > 0)
        {
            //Instantiate(bombPrefab, UNA CASILLA MAS QUE LINK, ROTACION NORMAL)           Deberia hacerse referencia a la direccion de link para instanciar
        }
        

            
        



    }
    
}