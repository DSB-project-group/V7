using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class player : MonoBehaviour
{

    private Transform tf;

    [SerializeField] private float speed = 3f;

    private float moveH;
    private float moveV;

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

        Vector3 movedir = new Vector3(-moveH ,0f, -moveV).normalized;

        transform.Translate(movedir * speed * Time.deltaTime);
    }
}
