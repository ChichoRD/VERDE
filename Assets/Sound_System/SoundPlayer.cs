using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public void Play(string name) {
        AudioManager.Instance.Play(name);
    }
}
