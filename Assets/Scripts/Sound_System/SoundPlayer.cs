using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public void Play(string name) {
        AudioManager.Instance.Play(name);
    }

    public void Stop(string name) {
        AudioManager.Instance.Stop(name);
    }

    public void StopAll() {
        AudioManager.Instance.StopAll();
    }
}
