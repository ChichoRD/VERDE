using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthSystem : MonoBehaviour


{
    public UnityEvent<int> OnHealthChange = new UnityEvent<int>();
    [SerializeField] UnityEvent onDeath = new UnityEvent();
    [SerializeField] UnityEvent OnTakeDamage = new UnityEvent();

    #region parameters 
    Rigidbody2D rb;
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


    //Cada 1 de vida es medio coraz�n, as� que link tiene 6 de vida. Algunos enemigos tienen 1 o 2.
    #endregion

    #region methods

    //Recibe da�o y se le resta a la vida, vale para link y para los enemigos.
    public void LoseHealth(int DamageTaken, Vector2 hitPoint)
    {
        Vector2 direction = ((Vector2)transform.position - hitPoint).normalized;
        //rb.velocity = direction * 5;
        OnTakeDamage?.Invoke();
        currenthealth -= DamageTaken;

        if (currenthealth <= 0)
        {
            onDeath?.Invoke();
        }

    }

    //Recupera 2 de vida equivalente a 1 coraz�n (espec�ficamente para link) cuando hay colisi�n con los corazones que dropean a veces los enemigos.
    public void Heal()
    {
        currenthealth += 2;

        if (currenthealth >= maxhealth) { currenthealth = maxhealth; }
    }

    //Aumenta la vida m�xima, es el item de la sala secreta que abres con la bomba. Se llama este m�todo si hay colisi�n entre el item y link.
    public void ContainerHeart()
    {
        maxhealth += 2;
        currenthealth += 2;
    }

    #endregion


    private void OnEnable()
    {
        currenthealth = maxhealth * 2;
    }


    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }
}
