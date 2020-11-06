using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionGame : MonoBehaviour
{
    [SerializeField] AudioSource musicOn;
    private float musicVol = 1f;

    private void Start()
    {
        musicOn.Play();
    }

    private void Update()
    {
        musicOn.volume = musicVol;
    }

    public void UpdateVolume(float vol) {
        musicVol = vol;
    }
}
