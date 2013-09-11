using UnityEngine;
using System.Collections;

public class Example_GuiSLider : MonoBehaviour {
    public float hSliderValue = 0.0F;
    void OnGUI() {
        hSliderValue = GUI.HorizontalSlider(new Rect(25, 25, 100, 30), hSliderValue, 0.0F, 10.0F);
    }
}