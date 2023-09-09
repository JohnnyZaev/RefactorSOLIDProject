using UnityEngine;

public class PlaySounds : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    public void PlayStepSound()
    {
        audioSource.Play();
    }
}
