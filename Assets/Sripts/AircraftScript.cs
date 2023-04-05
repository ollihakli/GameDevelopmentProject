using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;

    public float maxFallSpeed = 5f;
    public float speedUp = 8f;
    public GameOverScript gameOver;
    public bool aircraftIsAlive = true;
    public GameObject explosion;
    public ParticleSystem exhaustfumes;
    public AudioSourcePlayer audioPlayer;
    public AudioSource audioSource;
    private bool audioPlayed = false;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = GameObject.FindGameObjectWithTag("Game Over").GetComponent<GameOverScript>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        exhaustfumes.emissionRate = 0;
        if (Input.GetKey(KeyCode.Space) && aircraftIsAlive) // Ascending with holding space button
        {
            myRigidbody.AddForce(Vector2.up * speedUp, ForceMode2D.Force);
            exhaustfumes.emissionRate = 200;
            audioPlayer.AircraftSound();
        }
        if (myRigidbody.velocity.y < 0)
        {
            audioPlayer.AircraftSoundStop();
            if (myRigidbody.velocity.magnitude > maxFallSpeed) // Limiting maximum falling speed
            {
                myRigidbody.velocity = Vector2.ClampMagnitude(myRigidbody.velocity, maxFallSpeed);
            }
        }
        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        Instantiate(explosion, transform.position, transform.rotation);
        if (audioPlayed == false)
        {
            audioSource.Play();
            audioPlayed = true;
        }
        
        gameOver.gameOver();
        aircraftIsAlive = false;
    }
}
