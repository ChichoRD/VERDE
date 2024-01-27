using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour, IWeapon
{
    int amount=1; //cambiar esto
    [SerializeField]
    GameObject bombPrefab;
    
    public void Use(Vector2 playerPosition, Vector2 playerDirection)
    {

        //Checkear si bombas mayor a 0
        if (amount > 0)
        {
            Debug.Log("Bomb Attack");
            Instantiate(bombPrefab, playerPosition + playerDirection, Quaternion.identity); 
        }
    }
    
}