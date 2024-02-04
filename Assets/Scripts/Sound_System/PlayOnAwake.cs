using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnAwake : MonoBehaviour
{
    [SerializeField] private string soundName;
    void Start()
    {
        AudioManager.Instance.Play(soundName);
    }
}
