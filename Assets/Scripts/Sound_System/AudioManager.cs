using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    static AudioManager instance;
    static public AudioManager Instance => instance;
    
    public Sound[] GetSounds() => sounds;

    void Awake()
    {
        if(instance == null) {
            instance = this;
        } else {
            Destroy(gameObject);
            return;
        }

         foreach(Sound s in sounds) {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        } 
    }

    public void Play(string name) {
        Sound s = Array.Find(sounds, sound => sound._name == name);
        if(s == null) {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.source.Play();
    }

    public void PlayOneShot(string name)
    {
        Sound s = Array.Find(sounds, sound => sound._name == name);
        if(s == null) {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.source.PlayOneShot(s.clip);
    }

    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound._name == name);
        if(s == null) {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.source.Stop();
    }

    public void StopAll()
    {
        foreach(Sound s in sounds) {
            if(s.loop)
            {
                s.source.Stop();
            }
        }
    }

    public AudioSource GetAudioSource(string name)
    {
        Sound s = Array.Find(sounds, sound => sound._name == name);
        if(s == null) {
            Debug.LogWarning("Sound: " + name + " not found!");
            return null;
        }
        return s.source;
    }

    public Sound GetSound(string name)
    {
        Sound s = Array.Find(sounds, sound => sound._name == name);
        if(s == null) {
            Debug.LogWarning("Sound: " + name + " not found!");
            return null;
        }
        return s;
    }
}
