using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    float time;

   public Button button;


    void Update()
    {
        time += Time.deltaTime;

        var colors = button.colors;
        colors.normalColor = Color.white;
        button.colors = colors;

        if (time > EventListener.duration)
        {
            var x = button.colors;
            x.normalColor = Color.red;
            button.colors = x;
            time = 0;
        }
    }
}
