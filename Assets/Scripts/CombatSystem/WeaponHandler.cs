using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WeaponHandler : MonoBehaviour
{
    IWeapon[] weapons = new IWeapon[2];
    Transform _myTransform;
    [SerializeField]
    UnityEvent onUseItem = new UnityEvent();

    public void AAction(Vector2 direction)
    {
        if(weapons[0].Use(_myTransform.position , direction))
        {
            onUseItem.Invoke();

        }
    }

    public void BAction(Vector2 direction)
    {
        if (weapons[1].Use(_myTransform.position, direction))
        {
            onUseItem.Invoke();
        }
    }

    private void Start()
    {
        _myTransform = transform;

        //BORRAR MAS ADELANTE
        weapons[0] = GetComponent<Sword>();
        weapons[1] = GetComponent<Bomb>();
        
    }
}
