using UnityEngine;
using UnityEngine.UI;

public class TimeIndication : MonoBehaviour
{
    private LampController lampcontroller;
    public Slider Slider;
    public GameObject sliderLight;
    void Start()
    {
        lampcontroller = FindObjectOfType<LampController>();
        sliderLight.SetActive(true);
    }

    
    void Update()
    {
        float mappedLight = Mathf.Clamp01(lampcontroller.LightTimer / lampcontroller.maxLightTimer);
        Slider.value = mappedLight;
        
        if(mappedLight <= 0 )
        {
            sliderLight.SetActive(false);
        }
    }
}
