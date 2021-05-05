using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public CanvasGroup winBackground;
    public CanvasGroup failBackground;
    
    public AudioSource winAudio;
    public AudioSource failAudio;

    private bool isWin = false;
    private bool isFail = false;
    public float duration = 1f;
    private float passTime = 0;

    // Start is called before the first frame update
    public void Win()
    {
        isWin = true;    
    }

    // Update is called once per frame
    public void Fail()
    {
        isFail = true;
    }

    public void Update()
    {
        if(isWin)
        {
            showBackground(winBackground, winAudio);
        }
        else if(isFail)
        {
            showBackground(failBackground, failAudio);
        }
    }
    private void showBackground(CanvasGroup background, AudioSource audio)
    {
        passTime = passTime + Time.deltaTime;
        background.alpha = passTime / duration;

        if(!audio.isPlaying)
        {
            audio.Play();
        }
    }
}
