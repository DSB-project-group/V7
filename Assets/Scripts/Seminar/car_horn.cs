using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class car_horn : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private AudioClip clip;
    private AudioSource sound;

    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("on area");
        sound.enabled = true;
    }

    public void OnTriggerExit(Collider other)
    {
        sound.enabled = false;
    }


}
