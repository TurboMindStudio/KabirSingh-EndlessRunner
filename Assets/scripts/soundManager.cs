using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    public static soundManager soundManagerinstance;
    public AudioSource audioSource;
    public AudioClip coinsound;
    public AudioClip kabirAngrySound;
    public AudioClip explosionSound;
    public AudioSource bgSound;
    private void Awake()
    {
        soundManagerinstance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
