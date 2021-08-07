using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{

    public AudioSource WrongAnswer;

    public void PlayWrong()
    {
        WrongAnswer.Play();
    }
}
