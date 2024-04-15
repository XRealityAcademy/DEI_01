using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereAlphaChange : MonoBehaviour
{
    public float targetAlpha = 0f; // Target transparency value
    public float duration = 12f; // Duration of the change
    private Material material;
    private float startAlpha;
    private float time;
    void Start()
    {
        // Ensure the GameObject has a Renderer component with a material
        Renderer renderer = GetComponent<Renderer>();
        if (renderer == null)
        {
            Debug.LogError("Renderer component not found.");
            return;
        }
        // Duplicate the material to avoid changing the asset directly
        material = renderer.material;
        startAlpha = material.color.a;
        time = 0f;
    }
    void Update()
    {
        // Gradually change the alpha value of the material's color
        if (time < duration)
        {
            time += Time.deltaTime;
            float alpha = Mathf.Lerp(startAlpha, targetAlpha, time / duration);
            Color color = material.color;
            color.a = alpha;
            material.color = color;
        }
    }
    void OnDestroy()
    {
        // Clean up the duplicated material created at runtime
        if (material != null)
        {
            Destroy(material);
        }
    }
}
