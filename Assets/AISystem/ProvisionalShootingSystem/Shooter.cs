using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject _bulletPrefab;
    Rigidbody2D _rb;
    float shootForce = 10f;

    private void Awake() {
        _rb = GetComponent<Rigidbody2D>();
    }

    public void Shoot(Vector2 direction)
    {
        Vector2 lookDirection = direction;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        GameObject bullet = Instantiate(_bulletPrefab, transform.position, Quaternion.identity);
        bullet.transform.rotation = Quaternion.Euler(0, 0, angle - 90);
        bullet.GetComponent<Rigidbody2D>().velocity = direction * shootForce;
    }
}
