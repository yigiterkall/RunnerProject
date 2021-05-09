using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    public AudioSource collison;

    public void PlayCollison()
    {
        collison.Play();
    }
}
