using UnityEngine;

public class BackgroundAudio : MonoBehaviour
{
    [SerializeField] private AudioSource backgroundAudioSrc;
    [SerializeField, Tooltip("Check this, if personalisation of player should be ignored.")] 
    private bool shouldOverridePersonalisation = true;

    private void Start()
    {
        if (!backgroundAudioSrc.isPlaying)
        {
            backgroundAudioSrc.loop = true;
            backgroundAudioSrc.Play();
        }
    }

    public bool GetShouldOverridePersonalisation()
    {
        return shouldOverridePersonalisation;
    }
}
