using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class cube_sound : MonoBehaviour
{

    private Transform tf;
    private AudioSource sound;
    [SerializeField]private AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("touch");
        sound.PlayOneShot(clip);
    }
}
