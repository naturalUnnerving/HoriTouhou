using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;
    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;

        if (Input.GetKey(KeyCode.UpArrow)) {pos += new Vector3(0f, 1f, 0f) * movementSpeed * Time.deltaTime;}
        if (Input.GetKey(KeyCode.DownArrow)) {pos -= new Vector3(0f, 1f, 0f) * movementSpeed * Time.deltaTime;}
        if (Input.GetKey(KeyCode.LeftArrow)) {pos -= new Vector3(1f, 0f, 0f) * movementSpeed * Time.deltaTime;}
        if (Input.GetKey(KeyCode.RightArrow)) {pos += new Vector3(1f, 0f, 0f) * movementSpeed * Time.deltaTime;}

        transform.position = pos;
    }
}
