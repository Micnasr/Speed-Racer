using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class p2fuelbar : MonoBehaviour
{

    public Slider slider;

    public void SetMaxFuel2(int fuel2)
    {
        slider.maxValue = fuel2;
        slider.value = fuel2;
    }

    public void SetFuel2(int fuel2)
    {
        slider.value = fuel2;
    }
}
