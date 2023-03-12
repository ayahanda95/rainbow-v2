using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip HitCubeSound;
    static AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        HitCubeSound = Resources.Load<AudioClip>("HitTheCube");
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "HitTheCube":
                audioSource.PlayOneShot(HitCubeSound);
                break;
        }
    }
}
