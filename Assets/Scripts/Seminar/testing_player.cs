using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class player : MonoBehaviour
{

    private Transform tf;

    [SerializeField] private float speed = 2f;
    [SerializeField] private float runspeed = 5f;

    private float moveH;
    private float moveV;
    public AudioSource walking; 
    public AudioSource running;

    // Start is called before the first frame update
    void Awake()
    {
        transform.position = new Vector3(0.0f, 1.5f, 0.0f);
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    private void Update()
    {

        moveH = Input.GetAxis("Horizontal");
        moveV = Input.GetAxis("Vertical");

        Vector3 movedir = new Vector3(-moveH, 0f, -moveV).normalized;
        float currentSpeed = Input.GetKey(KeyCode.LeftShift) ? runspeed : speed;

        tf.Translate(movedir * currentSpeed * Time.fixedDeltaTime);

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            walking.enabled = true;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                walking.enabled = false;
                running.enabled = true;
            }
            else
            {
                running.enabled = false;
            }
        }
        else
        {
            walking.enabled = false;
            running.enabled = false;
        }
    }
}
