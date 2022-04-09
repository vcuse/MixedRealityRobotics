using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;

public class Jogging : MonoBehaviour
{
    public GameObject axis;
    public Vector3 rotation;
    public PinchSlider slider;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void rotateAxis()
    {
        float speed = slider.SliderValue;
        axis.transform.Rotate((speed - 0.5f) * rotation.x, (speed - 0.5f) * rotation.y, (speed - 0.5f) * rotation.z, Space.Self);
    }

}
