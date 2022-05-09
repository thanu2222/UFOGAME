using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    // Variable of type background Music
    private static BackgroundMusic backgroundMusic;
    // Which is called before the first frame so the music starts immediaetly
    void Awake()
    {
        // Checking if the background music is equal to 0
        if(backgroundMusic == null)
        {
            // if it is equal to zero this will be the background music
            backgroundMusic = this;
            DontDestroyOnLoad(backgroundMusic);

        }

        else
        {
            // Destroy's the gameObecjt when the background music is not equal to zero
            Destroy(gameObject);
        }

    }
}