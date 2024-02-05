using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthSu : MonoBehaviour
{
    [SerializeField]
    LinkStats _linkStats;
    [SerializeField]
    HealthSystem _healthSystem;
    public void HealthSuscribe(int newhealth)
    {
        
        _linkStats.currentHealth = newhealth ;
    }

    void Awake()
    {
        _healthSystem = GetComponent<HealthSystem>();
        _healthSystem.OnHealthChange.AddListener(HealthSuscribe);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
