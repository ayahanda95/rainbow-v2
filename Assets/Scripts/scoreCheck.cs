using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreCheck : MonoBehaviour
{
    public TMP_Text[] pcountText;
    public GameObject result;
    public AudioClip resultSound;
    public int resultPlayed;
    public GameObject[] cubes;
    public AudioClip[] clip;
    public int[] played;
    static AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        bool allInActive = true;

        for (int i = 0; i < cubes.Length; i++)
        {

            if (!cubes[i].activeInHierarchy)
            {
                pcountText[i].color = new Color32(0, 0, 0, 255);
                if (played[i] == 0)
                {
                    audioSource.PlayOneShot(clip[i]);
                    played[i] = 1;
                }
            }

        }

        for (int i = 0; i < cubes.Length; i++)
        {
            if (cubes[i].activeInHierarchy)
            {
                allInActive = false;
                break;
            }
        }

        if (allInActive)
        {
            result.SetActive(true);
            if (resultPlayed == 0)
            {
                StartCoroutine(ResSound());
                resultPlayed = 1;
            }
        }
    }

    IEnumerator ResSound()
    {
        yield return new WaitForSeconds(2);
        audioSource.PlayOneShot(resultSound);
    }
}
