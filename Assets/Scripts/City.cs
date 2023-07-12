using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City : MonoBehaviour
{
    public Material newMaterial;
    public Material newMaterial2;

    private void Start()
    {
     
        // 모든 Renderer 컴포넌트를 가져옴
        Renderer[] renderers = FindObjectsOfType<Renderer>();
        Debug.Log("newMaterial = " + newMaterial);
        foreach (Renderer renderer in renderers)
        {
            Debug.Log("renderer.gameObject.name = " + renderer.gameObject.name);
            if (renderer.gameObject.transform.parent != null)
            {
                Debug.Log("renderer.gameObject.transform.parent.name = " + renderer.gameObject.transform.parent.name);
                if (renderer.gameObject.transform.parent.name == "남산")
                {
                    // 메테리얼을 새로운 메테리얼로 변경
                    renderer.material = newMaterial2;
                }
                if (renderer.gameObject.transform.parent.name == "창문")
                {
                    // 메테리얼을 새로운 메테리얼로 변경
                    renderer.material = newMaterial;
                }
            }

        }

    }
}