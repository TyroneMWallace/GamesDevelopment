//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

//mark as serializable so that it appears in the inspector
[System.Serializable]

public class Sound
{
    //Allows us to name different elements
    public string name;

    //Drag and drop the audio clip we want to use
    public AudioClip clip;

    //Allows us to add sliders to the volume and pitch properties
    [Range(0f, 1f)]
    public float volume;
    [Range(0f, 1f)]
    public float pitch;

    public bool loop;

    
    [HideInInspector] //prevents public methods that would typically show in inspector, stay hidden
    public AudioSource source;
}
