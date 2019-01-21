using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource faintWind;
    public AudioSource concreteStep;
    void Start()
    {
        faintWind.Play();
    }
}
