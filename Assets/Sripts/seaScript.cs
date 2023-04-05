using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seaScript : MonoBehaviour
{
    private float speed = 11f;
    public Rigidbody2D localRigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Moving platform to the left
        localRigidbody2D.velocity = new Vector2(-1 * speed, 0);
    }
}
