using UnityEngine;

public class Siren : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private float _time;

    private bool _isPlay = false;
    private float _counter = 0f;
    private float degreeVolumeChange = 0.2f;

    private void Update()
    {
        _counter += Time.deltaTime;

        if (_counter >= _time)
        {
            if (_audioSource.isPlaying)
            {
                ChangeVolume();
            }

            _counter = 0f;
        }
    }

    public void Play()
    {
        _audioSource.Play();
        _isPlay = true;
    }

    public void Stop()
    {
        _isPlay = false;
    }

    private void ChangeVolume()
    {
        if (_isPlay == true && _audioSource.volume < 1)
        {
            _audioSource.volume += degreeVolumeChange;
        }
        else if (_isPlay == false && _audioSource.volume > 0)
        {
            _audioSource.volume -= degreeVolumeChange;
        }
    }
}
