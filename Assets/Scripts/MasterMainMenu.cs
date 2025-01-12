using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MasterMainMenu : MonoBehaviour
{
    public VolumeSO sliderValue;
    public Slider sliderOne;

    private void Start()
    {
        sliderOne.value = sliderValue.value;
        sliderValue.value = 1f;
    }

    private void FixedUpdate()
    {
        sliderValue.value = sliderOne.value;
    }
}