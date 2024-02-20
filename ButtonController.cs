using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public AudioClip[] audioClips; 
    private AudioSource audioSource;
    private int currentClipIndex = 0;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        if (audioClips != null && audioClips.Length > 0)
        {
            audioSource.clip = audioClips[currentClipIndex];
            audioSource.Play();

            currentClipIndex = (currentClipIndex + 1) % audioClips.Length;
        }
    }
}
