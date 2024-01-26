using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WeaponHandler : MonoBehaviour
{
    IWeapon[] weapons = new IWeapon[2];

    UnityEvent actionEvent = new UnityEvent();

    void AAction()
    {
        //weapons[0].Use();
        actionEvent?.Invoke();
    }

    void BAction()
    {
        //weapons[1].Use();
        actionEvent?.Invoke();
    }

}
