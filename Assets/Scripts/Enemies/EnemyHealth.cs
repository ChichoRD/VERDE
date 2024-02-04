using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    private int health;
    [SerializeField]
    private int maxhealth;

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health < 0)
        {
            gameObject.SetActive(false);
            //aquí también se puede meter un evento para cuando muere el monstruo que active la animación de cuando muere.
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
