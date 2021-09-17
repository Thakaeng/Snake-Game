using UnityEngine;

public class AudioControl : MonoBehaviour
{
    private AudioSource _audioSource;
    private bool hasStartePlaying = false;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void ToggleMusic()
    {
        if (!hasStartePlaying)
        {
            hasStartePlaying = true;
            _audioSource.Play();
            return;
        }
        
        switch (_audioSource.isPlaying)
        {
            case true: _audioSource.Pause();
                break;
            case false: _audioSource.UnPause();
                break;
        }
    }
}
