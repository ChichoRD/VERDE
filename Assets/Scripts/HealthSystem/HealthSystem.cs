using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthSystem : MonoBehaviour


{

    public UnityEvent<int> OnHealthChange = new UnityEvent<int>();

    #region parameters 

    public int maxhealth;
    int health;
    public int currenthealth
    {
        get { return health; }
        set
        {
            OnHealthChange?.Invoke(value);
            health = value;
            
        }

    }


    //Cada 1 de vida es medio corazón, así que link tiene 6 de vida. Algunos enemigos tienen 1 o 2.
    #endregion

    #region methods

    //Recibe daño y se le resta a la vida, vale para link y para los enemigos.
    public void LoseHealth(int DamageTaken)
    {
        health -= DamageTaken;

        if (health <= 0)
        {
            gameObject.SetActive(false);
        }

    }

    //Recupera 2 de vida equivalente a 1 corazón (específicamente para link) cuando hay colisión con los corazones que dropean a veces los enemigos.
    public void Heal()
    {
        health += 2;

        if (health >= maxhealth) { health = maxhealth; }
    }

    //Aumenta la vida máxima, es el item de la sala secreta que abres con la bomba. Se llama este método si hay colisión entre el item y link.
    public void ContainerHeart()
    {
        maxhealth += 2;
        health += 2;
    }

    #endregion


    void Start()
    {
        health = maxhealth;
    }


    void Update()
    {

    }
}
