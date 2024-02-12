using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolDownController : MonoBehaviour
{
    HealthSystem _healthSystem;
    [SerializeField] float coolDownTime = 0.5f;

    private void Awake() {
        _healthSystem = GetComponent<HealthSystem>();
        _healthSystem.OnTakeDamage.AddListener(ResetCoolDown);
    }

    void ResetCoolDown()
    {
        StartCoroutine(CoolDown());
    }

    IEnumerator CoolDown()
    {
        _healthSystem.canGetDamage = false;
        yield return new WaitForSecondsRealtime(coolDownTime);
        _healthSystem.canGetDamage = true;
    }
}
