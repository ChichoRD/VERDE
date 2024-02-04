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
        print("Shooting");
        GameObject bullet = Instantiate(_bulletPrefab, transform.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody2D>().velocity = direction * shootForce;
    }
}
