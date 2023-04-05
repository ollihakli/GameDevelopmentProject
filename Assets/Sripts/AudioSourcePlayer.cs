using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourcePlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip explosionSound, aircraftSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ExplosionSound()
    {
        audioSource.clip = explosionSound;
        audioSource.Play();
    }
    public void ExplosionSoundStop()
    {
        audioSource.clip = explosionSound;
        audioSource.Stop();
    }
    public void AircraftSound()
    {
        audioSource.clip = aircraftSound;
        audioSource.Play();
    }
    public void AircraftSoundStop()
    {
        audioSource.clip = aircraftSound;
        audioSource.Stop();
    }
}

// Sound effects: Sound Effect from <a href="https://pixabay.com/sound-effects/?utm_source=link-attribution&amp;utm_medium=referral&amp;utm_campaign=music&amp;utm_content=84742">Pixabay</a>
//Sound Effect from <a href="https://pixabay.com/sound-effects/?utm_source=link-attribution&amp;utm_medium=referral&amp;utm_campaign=music&amp;utm_content=6288">Pixabay</a>