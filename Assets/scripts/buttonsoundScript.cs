using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonsoundScript : MonoBehaviour
{
    public AudioSource sound;

    public void playsound()
    {
        sound.Play();
    }
}
