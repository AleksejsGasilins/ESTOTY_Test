using UnityEngine;

public class PlaySoundOnce : MonoBehaviour
{
    public AudioClip soundToPlay;
    public float volum = 1f;
    private AudioSource _audioSource;
    public bool alreadyPlayed = false;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!alreadyPlayed)
        {
            _audioSource.PlayOneShot(soundToPlay, volum);
            alreadyPlayed = true;
        }
    }
}
