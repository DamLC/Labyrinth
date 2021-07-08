using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public bool CanOpen = false;

    [SerializeField]
        AudioClip SndOpen, SndDenied;

    [SerializeField]
    Animator MyAnimator;

    [SerializeField]
    GameObject Finish;

    private AudioSource myAudioSource;

    private void Awake()
    {
        myAudioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && CanOpen)
        {
            MyAnimator.enabled = true;
            myAudioSource.PlayOneShot(SndOpen);
            Finish.SetActive(true);

        }
        else
        {
            myAudioSource.PlayOneShot(SndDenied);
        }
    }

}
