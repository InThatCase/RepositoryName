using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioScript : MonoBehaviour
{

    public Slider Volume;
    public AudioSource MyMusic;
    void Update () { 
    MyMusic.volume = Volume.value;
        } 

        
    }
 

