using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(AudioSource))]
public abstract class NPC : MonoBehaviour
{
    [SerializeField] private UnityEvent<string> onSpeak;
    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public virtual void Interact()
    {
        onSpeak?.Invoke(GetText());
        _audioSource.Play();
    }

    protected virtual string GetText()
    {
        return "";
    }
}
