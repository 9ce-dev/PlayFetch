using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool canStart = true;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        SpawnDog();
    }
    void SpawnDog()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canStart)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            canStart = false;
            Invoke("makeTrue", 1.0f);
        }
    }
    void makeTrue()
    {
        canStart = true;
    }
    
}