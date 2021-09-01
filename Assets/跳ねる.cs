using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 跳ねる : MonoBehaviour
{
    public AudioClip haneru;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            audioSource.PlayOneShot(haneru);
        }
    }
}
