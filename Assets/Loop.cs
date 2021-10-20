using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    public AudioSource[] Loops;
    private void OnMouseDown()
    {
        foreach (var cadaLoop in Loops)
        {
            cadaLoop.Stop();
        }
        GetComponent<AudioSource>().Play();

    }
}