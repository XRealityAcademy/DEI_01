using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientLightAdjuster : MonoBehaviour
{
    public Color targetAmbientLight = Color.white; // Target ambient light color
    public float duration = 5.0f; // Duration from dark to full light
    private Color startAmbientLight;
    private float timer;
    void Start()
    {
        startAmbientLight = RenderSettings.ambientLight;
        timer = 0.0f;
    }
    void Update()
    {
        if (timer < duration)
        {
            timer += Time.deltaTime;
            float blend = Mathf.Clamp01(timer / duration);
            RenderSettings.ambientLight = Color.Lerp(startAmbientLight, targetAmbientLight, blend);
        }
    }
}
