using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NightDayCycle : MonoBehaviour
{
    private Light light;
    public float cycleRate = 0.5f;
    public float minIntensity = 0f;
    public float maxIntensity = 4f;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        float lerp = Mathf.PingPong(minIntensity+Time.time*cycleRate, maxIntensity);
        light.intensity = lerp;
        RenderSettings.skybox.SetColor("_Tint", Color.Lerp(new Color(0.24f, 0.30f, 0.36f ,1f), Color.white, lerp/maxIntensity));
        //RenderSettings.ambientIntensity = Mathf.PingPong(minIntensity+Time.time*cycleRate, maxIntensity);
        //RenderSettings.reflectionIntensity = Mathf.PingPong(minIntensity+Time.time*cycleRate, maxIntensity);
    }
}
