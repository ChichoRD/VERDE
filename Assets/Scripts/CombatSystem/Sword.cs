using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Sword : MonoBehaviour, IWeapon
{
   
    [SerializeField]
    private GameObject swordHitbox;
    private GameObject currentHitbox;
    private PlayerAnimatorController playerAnimatorController;
    [SerializeField] LinkStats linkStats;
    ShootingComponent attachedSwordBeam;

    void Start()
    {
        playerAnimatorController = GetComponent<PlayerAnimatorController>();
        attachedSwordBeam = GetComponent<ShootingComponent>();
    }

    public bool Use(Vector2 playerPosition, Vector2 playerDirection)
    {
        if(linkStats.hasSword)
        {
            AudioManager.Instance.PlayOneShot("LanzarEspada");
            playerAnimatorController.onUsingItem(true, 0);

            currentHitbox =Instantiate(swordHitbox, playerPosition + playerDirection, Quaternion.identity);
            currentHitbox.GetComponent<SwordHitbox>()._animatorController = GetComponent<PlayerAnimatorController>();

            //Checkear si Link est� con la vida al completo. Si lo est�, disparar un prefab de proyectil
            //Checkear si Link est� con la vida al completo. Si lo est�, disparar un prefab de proyectil.

            if(linkStats.currentHealth >= linkStats.maxHealth * 2)
            {
                attachedSwordBeam.Shoot(playerDirection);
            }
 
        }
        return linkStats.hasSword;
    }
}