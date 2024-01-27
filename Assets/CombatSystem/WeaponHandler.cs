using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WeaponHandler : MonoBehaviour
{
    IWeapon[] weapons = new IWeapon[2];
    Transform _myTransform;

    UnityEvent actionEvent = new UnityEvent();

    public void AAction(Vector2 direction)
    {
        weapons[0].Use(_myTransform.position , direction);
        actionEvent?.Invoke();
    }

    public void BAction(Vector2 direction)
    {
        weapons[1].Use(_myTransform.position ,direction);
        actionEvent?.Invoke();
    }

    private void Start()
    {
        _myTransform = transform;

        //BORRAR MAS ADELANTE
        weapons[0] = GetComponent<Sword>();
        weapons[1] = GetComponent<Bomb>();
        
    }
}
