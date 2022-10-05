using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager _instance;
    private void Awake()
    {
        if (!_instance)
        {
            _instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeAudioSpeed(float newPitch)
    {
        GetComponent<AudioSource>().pitch = newPitch;
    }
    
    public float GetPitch()
    {
        return GetComponent<AudioSource>().pitch;
    }
}
