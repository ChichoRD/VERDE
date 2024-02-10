using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ShootingComponent : MonoBehaviour
{
    #region references

    private Transform _myTransform;

    [SerializeField]
    private GameObject projectileObject;

    #endregion

    #region methods

    public void Shoot(Vector2 direction)
    {
        GameObject projectileInstance = Instantiate(projectileObject, _myTransform.position, Quaternion.identity);

        projectileInstance.GetComponent<ProjectileMovement>().SetDirection(direction);
    }

    #endregion

    void Start()
    {
        _myTransform = transform;
    }

    void Update()
    {
        
    }
}
