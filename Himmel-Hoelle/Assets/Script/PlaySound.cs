using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource staySound;
    public AudioSource ejectedSound;
    public AudioSource rollSound;

    public void playStaySound()
    {
        staySound.Play();
    }

    public void playEjectedSound()
    {
        ejectedSound.Play();
    }

    public void playRollSound()
    {
        rollSound.Play();
    }
}
