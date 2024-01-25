using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour, IWeapon
{
    int damage;
    public void Use()
    {
        Debug.Log("Sword Attack");
    }
}