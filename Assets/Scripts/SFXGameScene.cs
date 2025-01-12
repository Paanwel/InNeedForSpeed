using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SFXGameScene : MonoBehaviour
{
    public VolumeSO sliderValue;
    public Slider sliderTwo;

    private void Start()
    {
        sliderTwo.value = sliderValue.value;
    }

    private void Update()
    {
        sliderValue.value = sliderTwo.value;
    }
}