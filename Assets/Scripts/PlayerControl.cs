using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private GameObject projectilePrefab;
    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        PlayerFire();
    }

    void PlayerMovement()
    {
        pos = transform.position;

        if (Input.GetKey(KeyCode.UpArrow)) {pos += new Vector3(0f, 1f, 0f) * movementSpeed * Time.deltaTime;}
        if (Input.GetKey(KeyCode.DownArrow)) {pos -= new Vector3(0f, 1f, 0f) * movementSpeed * Time.deltaTime;}
        if (Input.GetKey(KeyCode.LeftArrow)) {pos -= new Vector3(1f, 0f, 0f) * movementSpeed * Time.deltaTime;}
        if (Input.GetKey(KeyCode.RightArrow)) {pos += new Vector3(1f, 0f, 0f) * movementSpeed * Time.deltaTime;}

        transform.position = pos;
    }

    void PlayerFire()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            GameObject bullet = ObjectPool.SharedInstance.GetPooledObject(); 
            if (bullet != null)
            {
                bullet.transform.position = transform.position;
                bullet.transform.rotation = transform.rotation;
                bullet.SetActive(true);
            }
        }
        if (Input.GetKeyDown(KeyCode.X)) {/* player kick to handle ying yang orb */}
    }
}
