using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tecla : MonoBehaviour
{
    private AudioSource audioS;

    private void Start()
    {
        audioS = GetComponent<AudioSource>();
    }
    private void OnMouseDown()
    {
        audioS.Play();
    }

    private void OnMouseUp()
    {
        audioS.Stop();
    }
}
