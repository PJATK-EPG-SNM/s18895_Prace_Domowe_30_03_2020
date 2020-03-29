using UnityEngine;
using System.Collections;

public class FullScreen : MonoBehaviour
{
    void Start()
    {
        float ScreenWidth = Screen.width;
        float ScreenHeight = Screen.height;
        float PixelInsetX = (Screen.width / 2) * -1;
        float PixelInsetY = (Screen.height / 2) * -1;
    //    guiTexture.pixelInset = new Rect(PixelInsetX, PixelInsetY, ScreenWidth, ScreenHeight);
    }
}
