using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LightIntensity : MonoBehaviour
{
    public Light myLight;
    private float myintensity;
    //private float Swidth = Screen.width;
    //private float Sheight = Screen.height;
    public Slider lightSlider;

    private void Awake()
    {
        /*myLight = GetComponent<Light>();
        lightSlider = GetComponent<Slider>();*/
        myintensity = lightSlider.value;
        lightSlider.maxValue = 1f;


    }

    private void Update()
    {
        myintensity = lightSlider.value;
        myLight.intensity = myintensity;
        
    }

    /*private void OnGUI()
    {
        myintensity = GUI.HorizontalSlider
            (new Rect(Swidth / 2f - 150f, Sheight / 1.1f, 300, 30),
            myintensity, 0.0f, 10.0f);
    }*/
}