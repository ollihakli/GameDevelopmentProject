using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpawnScrict : MonoBehaviour
{
    public GameObject balloon;
    public float spawnRate = 3;
    private float timer = 0;
    public float heightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        SpawnBalloon();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        } else
        {
            SpawnBalloon();
            timer = 0;
        }
        
    }
    void SpawnBalloon()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(balloon, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
