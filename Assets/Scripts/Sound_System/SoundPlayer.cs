using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{

    [SerializeField] string mainSong = "Overworld";

    private void Start()
    {
        Play(mainSong);
    }
    public void Play(string name) {
        AudioManager.Instance.Play(name);
    }
}
