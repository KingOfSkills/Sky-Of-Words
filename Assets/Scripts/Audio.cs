using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] private AudioSource keyboardAudio;
    [SerializeField] private AudioSource completeAudio;
    [SerializeField] private AudioSource failedAudio;

    public void PlayType()
    {
        keyboardAudio.PlayOneShot(keyboardAudio.clip);
    }
    public void PlayComplete()
    {
        completeAudio.PlayOneShot(completeAudio.clip);
    }
    public void PlayFailed()
    {
        failedAudio.PlayOneShot(failedAudio.clip);
    }
}
