using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamsanMeterial : MonoBehaviour
{
    public Material newMaterial;
    public Material newMaterial2;
    public float blinkInterval = 0.7f; 
    public float delay = 60f;
    private Renderer[] renderers;
    private Material newMaterial3;
    private bool isBlinking;

    private void Start()
    {
        renderers = FindObjectsOfType<Renderer>();
        newMaterial3 = renderers[0].material;
        isBlinking = false;

        foreach (Renderer renderer in renderers)
        {
            if (renderer.gameObject.transform.parent != null)
            {
                if (renderer.gameObject.transform.parent.name == "남산")
                {
                    renderer.material = newMaterial3;
                }
                else if (renderer.gameObject.transform.parent.name == "창문")
                {
                    renderer.material = newMaterial3;
                }
            }
        }


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
            isBlinking = !isBlinking; 

            foreach (Renderer renderer in renderers)
            {
                if (renderer.gameObject.transform.parent != null)
                {
                    if (renderer.gameObject.transform.parent.name == "남산")
                    {
                        renderer.material = isBlinking ? newMaterial2 : newMaterial3;
                    }
                    else if (renderer.gameObject.transform.parent.name == "창문")
                    {
                        renderer.material = isBlinking ? newMaterial : newMaterial3;
                    }
                }
            }

            yield return new WaitForSeconds(blinkInterval);
        }
    }
}