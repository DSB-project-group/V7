using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class press_to_play : Interactable
{

    public AudioSource music;
    [SerializeField] private AudioClip ac;

    
    public GameObject tf1;
    public GameObject tf2;
    // Start is called before the first frame update
    void Start()
    {
       music.clip = ac;

    }

    // Update is called once per frame
    void Update()
    {

        //music.PlayOneShot(ac);
    }

    public void playMyAudio(AudioClip clipToPlay)
    {
        music.clip = clipToPlay;
        music.Play();
        tf1.GetComponent<press_to_play>().stopMyAudio();
        tf2.GetComponent<press_to_play>().stopMyAudio();
        Debug.Log("play");
    }

    public void stopMyAudio()
    {
        music.Stop();
        Debug.Log($"stopped: {gameObject.name}");
    }
}
