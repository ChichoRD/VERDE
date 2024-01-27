using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPrefab : MonoBehaviour
{
    [SerializeField]
    float explodeTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        //Esperar por 1 segundo segun el video

        //Cambiar el sprite de la bomba en el animator

        //Crear hitbox de la explosion

        //Eliminar hitbox de la explosion cuando llega evento de animacion

        Destroy(gameObject);
    }
    
}
