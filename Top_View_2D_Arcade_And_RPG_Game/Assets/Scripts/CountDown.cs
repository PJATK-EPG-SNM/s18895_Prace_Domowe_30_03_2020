using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{ 
    float currentTime = 0f;
    float startTime = 3f;
    [SerializeField] Text CountDownText;
    void Start()
    {
        currentTime = startTime;
    }
    void Update()
    { 
        currentTime -= 1 * Time.deltaTime;
        CountDownText.text = currentTime.ToString("0");
        if (currentTime<=0)
        {
            currentTime = 0;
        }
    }
}
