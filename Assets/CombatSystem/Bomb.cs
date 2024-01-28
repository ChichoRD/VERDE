using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour, IWeapon
{
    int amount=1; //cambiar esto
    [SerializeField]
    GameObject bombPrefab;
    Animator animator;
    [SerializeField]
    WeaponHandler weaponHandler;
    
    public void Use(Vector2 playerPosition, Vector2 playerDirection)
    {
        animator = GetComponent<Animator>();
        //Checkear si bombas mayor a 0
        if (amount > 0)
        {
            Debug.Log("Bomb Attack");
            //CAMBIAR A ANIMACION DE PONER BOMBA
            Instantiate(bombPrefab, playerPosition + playerDirection, Quaternion.identity);
            
        }
    }
    
}