using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(AudioSource))]
public abstract class NPC : MonoBehaviour
{
    public UnityEvent<string> onSpeak;
    public AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public virtual void Interact()
    {
        onSpeak?.Invoke(GetText());
        audioSource.Play();
    }

    protected virtual string GetText()
    {
        return "";
    }
}
