//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;

    public static AudioManager instance;

    // Awake is similar to start method but called before it, like a preload
    void Awake()
    {
        // if we dont have a Audio Manager, then it gets one, if it already has one, then it destorys it.
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        //the music will continue playing through different scenes using this method
        DontDestroyOnLoad(gameObject);

        // Here we are looping through the array, anding a sound for each audio source
        // so that an audio source is added for each sound in the array
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
       
            //options in the inspector to change how we want it
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    void Start()
    {
        Play("BackgroundMusicPlay");
    }

    //the method we call when we want to play a certain sound
    public void Play(string name)
    {
        // Find the sound in the sounds array, where the sounds name is equal to the 
        // name and is stored the variable called s
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }
}
