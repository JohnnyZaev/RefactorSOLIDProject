using UnityEngine;
using UnityEngine.Events;

public class NPC_Friendly : MonoBehaviour
{
    public UnityEvent<string> onSpeak;
    public AudioSource audioSource;
    public string text = "Hi there. Look out for that KOBOLD on the other side!";

    public void Talk()
    {
        onSpeak?.Invoke(text);
        audioSource.Play();
    }
}
