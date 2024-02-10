using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordBulletPrefab : MonoBehaviour
{
    [SerializeField]
    private float speed = 1f;

    private Shooter shooter;

    private Vector3 direction = new Vector2(-Mathf.Sqrt(2) / 2, Mathf.Sqrt(2) / 2);

    private Collider2D _myCollider2d;

    private void PrefabAngle(int i)
    {
        if(i == 0)
        {
            direction = new Vector2 (-Mathf.Sqrt(2)/2, Mathf.Sqrt(2)/2);
        }
        else if(i == 1)
        {
            direction = new Vector2(Mathf.Sqrt(2) / 2, Mathf.Sqrt(2) / 2);
        }
        else if (i == 2)
        {
            direction = new Vector2(Mathf.Sqrt(2) / 2, -Mathf.Sqrt(2) / 2);
        }
        else
        {
            direction = new Vector2(-Mathf.Sqrt(2) / 2, -Mathf.Sqrt(2) / 2);
        }
    }

    private void Awake()
    {
        shooter = GetComponent<Shooter>();
        _myCollider2d = GetComponent<Collider2D>();
    }

    public void SwordBulletShoot()
    {
        for (int i = 0;i < 4; i++)
        {
            PrefabAngle(i);
            shooter.Shoot(direction);
            Debug.Log(i);
        }
    }

}
