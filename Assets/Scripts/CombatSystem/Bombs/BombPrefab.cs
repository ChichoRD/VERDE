using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;

public class BombPrefab : MonoBehaviour
{
    [SerializeField] GameObject explosionEffect1;
    [SerializeField] GameObject explosionEffect2;

    private BombAnimator bombAnimator;
    Transform _myTransform;
    [SerializeField]
    float explodeTime = 1f;

    public PlayerAnimatorController _animationController;

    [SerializeField]
    float preparationTime = 1f;

    [SerializeField]
    float linkStopTime = 0.5f;
    bool isStopped = true;

    [SerializeField]
    UnityEvent enableInput = new UnityEvent();

    [SerializeField]
    int damage = 1;

    float currentTime = 0f;
    float currentTime2 = 0f;

    Collider2D explosion;

    public bool exploding = false; //SE USA EN EL ANIMATOR DE LA BOMBA

    public void BombFinish()
    {
        explosion.enabled = false;
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.TryGetComponent(out HealthSystem healthSystem))
        {
            healthSystem.LoseHealth(damage, transform.position);
        }


    }

    // Start is called before the first frame update
    void Update()
    {
        //Esperar por 1 segundo segun el video
        currentTime = currentTime + Time.deltaTime; //fase 0. Sin explotar

        if (currentTime>linkStopTime && isStopped) //Devolver el input a Link
        {
            isStopped = false;
            enableInput.Invoke();
            PlayerAnimatorCall();
        }

        if (currentTime > preparationTime) //fase 1. Explota
        {
            currentTime2 = currentTime2 + Time.deltaTime;
            exploding = true;
            bombAnimator.CallBombAnimator(exploding);
            explosion.enabled = true;

            explosionEffect1.SetActive(true);
            explosionEffect2.SetActive(true);
            
            if (currentTime2 > explodeTime)  //fase 2. Se destruye
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
        bombAnimator = GetComponent<BombAnimator>();

        
    }

    
    public void PlayerAnimatorCall()
    {
        _animationController.onUsingItem(false, 1);
    }

}
