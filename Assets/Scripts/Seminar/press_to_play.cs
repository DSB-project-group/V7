using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class press_to_play : MonoBehaviour
{

    [SerializeField] public AudioSource music;
    
    public GameObject tf1;
    public GameObject tf2;

    //private bool isPress = false;
    // Start is called before the first frame update
    void Start()
    {
       music = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        //music.PlayOneShot(ac);
    }

    public void OnTriggerEnter(Collider other)
    {
        playMyAudio();
    }

    public void playMyAudio()
    {
        music.enabled = true;
        tf1.GetComponent<press_to_play>().stopMyAudio();
        tf2.GetComponent<press_to_play>().stopMyAudio();
        Debug.Log("play");
    }

    public void stopMyAudio()
    {
        music.enabled=false;
        Debug.Log($"stopped: {gameObject.name}");
    }
}
