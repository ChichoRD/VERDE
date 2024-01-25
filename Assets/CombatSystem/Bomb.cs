using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour, IWeapon
{
    int amount = 0;
    public void Use()
    {
        Debug.Log("Bomb Attack");
    }
}