using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHandler : MonoBehaviour
{
    IWeapon[] weapons = new IWeapon[2];

    void AAction()
    {
        weapons[0].Use();
    }

    void BAction()
    {
        weapons[1].Use();
    }
}
