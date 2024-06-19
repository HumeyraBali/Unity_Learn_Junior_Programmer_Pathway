using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 30;
    public GameObject [] projectilePrefab;
    int projectileIndex;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput =  Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        // Keep player in bounds
        if (transform.position.x < -xRange) {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange) {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {

            // Launch a projectile from the player
            projectileIndex = Random.Range(0,projectilePrefab.Length);
            Instantiate(projectilePrefab[projectileIndex],transform.position,projectilePrefab[projectileIndex].transform.rotation);
            //Debug.Log(projectileIndex);
            
        }
    }
}
