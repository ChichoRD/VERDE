using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour, IWeapon
{
    [SerializeField]
    GameObject bombPrefab;
    PlayerAnimatorController playerAnimatorController;
    [SerializeField]
    WeaponHandler weaponHandler;

    [SerializeField]
    LinkStats status;

    GameObject instantiatedBomb;
    
    public bool Use(Vector2 playerPosition, Vector2 playerDirection)
    {
        
        //Checkear si bombas mayor a 0
        if (status.bombCount > 0 && instantiatedBomb == null)
        {
            status.bombCount--;
            playerAnimatorController.onUsingItem(true, 1);
            instantiatedBomb = Instantiate(bombPrefab, playerPosition + playerDirection, Quaternion.identity);
            instantiatedBomb.GetComponent<BombPrefab>()._animationController = playerAnimatorController;
            return true;
        }
        else return false;
        
    }
    private void Start()
    {
        playerAnimatorController = GetComponent<PlayerAnimatorController>();
    }

}