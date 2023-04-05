using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudbaseSpwanScript : MonoBehaviour
{
    public GameObject cloudbase;
    public float spawnRate = 3;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        spawnCloudbase();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnCloudbase();
            timer = 0;
        }
        
    }
    void spawnCloudbase()
    {
        Instantiate(cloudbase, transform.position, transform.rotation);
        
    }
}
