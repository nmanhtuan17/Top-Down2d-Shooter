using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    [SerializeField] List<AudioSource> audioSources;
    [SerializeField] AudioSource bgm;

    private void Awake() {
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlaySFX(int soundToPlay)
    {
        audioSources[soundToPlay].Stop();

        audioSources[soundToPlay].pitch = Random.Range(.9f, 1.1f);

        audioSources[soundToPlay].Play();
    }
}
