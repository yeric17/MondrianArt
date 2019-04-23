using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveARObject : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] AudioClip audioToPlay;
    [SerializeField] string animName;

    private AudioSource audioPlayer;

    private Animator thisAnimator;
    void Start()
    {
        if(GetComponentInChildren<AudioSource>())
        audioPlayer = GetComponentInChildren<AudioSource>();
        if(GetComponentInChildren<Animator>())
        thisAnimator = GetComponentInChildren<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Interact()
    {
        print("OBJETO INTERACTUANDO");
        if(audioToPlay != null)
        {
            audioPlayer.clip = audioToPlay;
            audioPlayer.Play();
        }
        if(thisAnimator != null)
        {
            thisAnimator.SetBool("Interact", true);
        }
    }

    public void StopInteraction()
    {
        if (thisAnimator != null)
            thisAnimator.SetBool("Interact", false);

        if (audioPlayer != null)
            audioPlayer.Stop();

    }
}
