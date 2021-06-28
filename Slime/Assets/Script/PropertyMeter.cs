using UnityEngine;
using UnityEngine.UI;

// Renderer - Display graphic in Unity
public class PropertyMeter : MonoBehaviour
{

    // Variables
    public Slider meterSlider;

    public void UpdateMeter(float currentValue, float maxValue)
    {
        float percentageResult = currentValue / maxValue;
        Debug.Log("Current value" + currentValue);
        Debug.Log("MAx Value" + maxValue);
        Debug.Log("Percentage Value" + percentageResult);
        meterSlider.value = percentageResult;
    }
}
