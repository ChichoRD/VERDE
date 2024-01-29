using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour, IWeapon
{
    [SerializeField]
    GameObject bombPrefab;
    Animator animator;
    [SerializeField]
    WeaponHandler weaponHandler;

    [SerializeField]
    LinkStats status;

    GameObject instantiatedBomb;
    
    public bool Use(Vector2 playerPosition, Vector2 playerDirection)
    {
        animator = GetComponent<Animator>();
        //Checkear si bombas mayor a 0
        if (status.bombCount>0 && instantiatedBomb==null)
        {
            status.bombCount--;
            Debug.Log("Bomb Attack");
            //CAMBIAR A ANIMACION DE PONER BOMBA
            instantiatedBomb = Instantiate(bombPrefab, playerPosition + playerDirection, Quaternion.identity);
        }

        return (status.bombCount > 0 && instantiatedBomb ==null);
    }
    
}