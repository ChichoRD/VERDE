using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class BombPrefab : MonoBehaviour
{
    Transform _myTransform;
    [SerializeField]
    float explodeTime = 1f;
    [SerializeField]
    int damage = 1;
    float currentTime = 0f;
    float currentTime2 = 0f;

    Collider2D explosion;

    public void BombFinish()
    {
        explosion.enabled = false;
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<HealthSystem>() != null)
        {
            HealthSystem healthSystem = collision.gameObject.GetComponent<HealthSystem>();
            healthSystem.LoseHealth(damage);
        }
    }

    // Start is called before the first frame update
    void Update()
    {
        //Esperar por 1 segundo segun el video
        currentTime = currentTime + Time.deltaTime;

        if (currentTime > explodeTime)
        {
            currentTime2 = currentTime2 + Time.deltaTime;
            //Cambiar el sprite de la bomba en el animator

            //Crear hitbox de la explosion
            
            explosion.enabled = true;

            
            if (currentTime2 > explodeTime) //DEBUG. SE NECESITA QUE EL EVENTO DE ANIMACION LLAME A BombFinish()
            {
                BombFinish();
            }
            
        }

    }
    private void Start()
    {
        explosion = GetComponent<Collider2D>();
        explosion.enabled = false;
        _myTransform = transform;
    }

}
