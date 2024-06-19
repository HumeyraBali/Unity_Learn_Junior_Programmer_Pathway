using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[ ] animalPrefabs;
    public GameObject [] projectilePrefab;
    void OnTriggerEnter(Collider other) {
        Destroy(gameObject);
        Destroy(other.gameObject);  
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
