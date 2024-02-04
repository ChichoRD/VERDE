using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionEffect : MonoBehaviour
{
    [SerializeField] private float startTime = 0.0f;
    private Renderer[] EffectRenderer;
    void Update()
    {
        startTime = startTime + Time.deltaTime;

        if (startTime < 0.10f)
        {
            for (int i = 0;i<EffectRenderer.Length; i++)
            {
                EffectRenderer[i].enabled = true;
            }
        }
        else
        {
            for (int i = 0; i < EffectRenderer.Length; i++)
            {
                EffectRenderer[i].enabled = false;
            }

        }

        if(startTime >= 0.2f)
        {
            startTime = 0.0f;
        }
    }
    private void Start()
    {
        EffectRenderer = GetComponentsInChildren<Renderer>();
    }
}
