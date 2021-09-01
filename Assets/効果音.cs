using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 効果音 : MonoBehaviour
{
    public AudioClip jump;
    public AudioClip syokuji;
    public AudioClip syougeki;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            audioSource.PlayOneShot(jump);
        }
    }
}
