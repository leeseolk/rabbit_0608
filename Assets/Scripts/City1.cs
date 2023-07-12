using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City1 : MonoBehaviour
{
    public Material newMaterial;
    public Material newMaterial2;
    public float blinkInterval = 0.5f; // ±ôºıÀÌ´Â °£°İ ½Ã°£
    public float delay = 50f; // ½ÃÀÛ µô·¹ÀÌ ½Ã°£

    private Renderer[] renderers;
    private Material originalMaterial;
    private bool isBlinking;

    private void Start()
    {
        renderers = FindObjectsOfType<Renderer>();
        originalMaterial = renderers[0].material;
        isBlinking = false;

        StartCoroutine(StartBlinking());
    }

    private IEnumerator StartBlinking()
    {
        yield return new WaitForSeconds(delay);

        StartCoroutine(BlinkMaterials());
    }

    private IEnumerator BlinkMaterials()
    {
        while (true)
        {
            isBlinking = !isBlinking; // ±ôºıÀÌ´Â »óÅÂ Åä±Û

            foreach (Renderer renderer in renderers)
            {
                if (renderer.gameObject.transform.parent != null)
                {
                    if (renderer.gameObject.transform.parent.name == "Terr_02")
                    {
                        renderer.material = isBlinking ? newMaterial2 : originalMaterial;
                    }
                    else if (renderer.gameObject.transform.parent.name == "Terr_18")
                    {
                        renderer.material = isBlinking ? newMaterial : originalMaterial;
                    }
                }
            }

            yield return new WaitForSeconds(blinkInterval);
        }
    }
}
