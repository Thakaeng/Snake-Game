using UnityEngine;

public class AudioControl : MonoBehaviour
{
    private AudioSource _audioSource;
    private bool _hasStartedPlaying;

    private void Awake()
    {
        _hasStartedPlaying = false;
    }

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void ToggleMusic()
    {
        if (!_hasStartedPlaying)
        {
            _hasStartedPlaying = true;
            _audioSource.Play();
            return;
        }
        
        switch (_audioSource.isPlaying)
        {
            case true:
                _audioSource.Pause();
                break;
            case false:
                _audioSource.UnPause();
                break;
        }
    }
}
