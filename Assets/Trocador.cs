using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trocador : MonoBehaviour
{
    public AudioSource[] teclas;
    
    private void OnMouseDown()
    {
        AudioSource audioSource = GetComponent<AudioSource>();

        foreach (var cadaTecla in teclas)
        {
            cadaTecla.clip = audioSource.clip;
        }

        audioSource.Play();
    }
}
