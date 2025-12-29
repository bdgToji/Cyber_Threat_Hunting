using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource src;

    public void PlaySound(AudioClip sfx)
    {
        src.clip = sfx;
        src.Play();
    }
}
