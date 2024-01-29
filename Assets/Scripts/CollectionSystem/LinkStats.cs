using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "LinkStats", menuName = "MAP-World-Inc/LinkStats", order = 0)]
public class LinkStats : ScriptableObject 
{
    public int currentHealth;
    public int bombCount;
    public int rupeeCount;
    public int keyCount;

    public void Reset()
    {
        bombCount = 0;
        rupeeCount = 0;
        keyCount = 0;
    }
}

