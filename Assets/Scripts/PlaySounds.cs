using UnityEngine;

public class PlaySounds : MonoBehaviour
{
    public AudioSource audioSource;
    public void PlayStepSound()
    {
        audioSource.Play();
    }
}
