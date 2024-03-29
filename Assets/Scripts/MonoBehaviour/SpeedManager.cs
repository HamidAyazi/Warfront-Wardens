using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedManager : MonoBehaviour
{
    [SerializeField] private Button speedButton;
    [SerializeField] private Sprite speed1xImage;
    [SerializeField] private Sprite speed2xImage;
    [SerializeField] private Sprite speed3xImage;
    
    public static int Speed = 1;

    // Start is called before the first frame update
    private void Start()
    {
        Time.timeScale = Speed;
    }

    private void X2Speed() {
        Speed = 2;
        Time.timeScale = 2;
        speedButton.image.sprite = speed2xImage;
    }

      private void X3Speed() {
        if(GameStats.speed3x){
            Speed = 3;
            Time.timeScale = 3;
            speedButton.image.sprite = speed3xImage;
        } else {
            X1Speed();
        }
    }

      private void X1Speed() {
        Speed = 1;
        Time.timeScale = 1;
        speedButton.image.sprite = speed1xImage;
    }

    /// <summary>
    /// Change speed of the <c>PlayScene</c>.
    /// </summary>
    public void ChangeSpeed()
    {
        //play click sound
        SoundManager.PlaySound(Sound.ButtonClick);
        // change speed
        if (Speed == 1)
        {
            X2Speed();
        }
        else if (Speed == 2)
        {
            X3Speed();
        }
        else if (Speed == 3)
        {
            X1Speed();
        }
    }
}
