using System.Collections;
using System.Collections.Generic;
using uOSC;
using UnityEngine;
using UnityEngine.UI;

public class OSCValueSender : MonoBehaviour
{

    [SerializeField] uOscClient client;
    Slider slider;

    private void Start ()
    {
        slider = GetComponent<Slider> ();
        if (!slider) return;
    }

    public void OnValueChanged ()
    {
        client.Send ("/TouchDesigner/val", slider.value);
    }
}