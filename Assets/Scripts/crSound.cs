using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crSound : MonoBehaviour
{
    private int played;
    static AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        played = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (played == 0)
        {
            StartCoroutine(ResSound());
            played = 1;
        }
    }

    IEnumerator ResSound()
    {
        yield return new WaitForSeconds(2);
        audioSource.PlayOneShot(audioSource.clip);
    }
}
