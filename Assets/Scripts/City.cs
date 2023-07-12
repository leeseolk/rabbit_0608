using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City : MonoBehaviour
{
    public Material newMaterial;
    public Material newMaterial2;

    private void Start()
    {
     
        // ��� Renderer ������Ʈ�� ������
        Renderer[] renderers = FindObjectsOfType<Renderer>();
        Debug.Log("newMaterial = " + newMaterial);
        foreach (Renderer renderer in renderers)
        {
            Debug.Log("renderer.gameObject.name = " + renderer.gameObject.name);
            if (renderer.gameObject.transform.parent != null)
            {
                Debug.Log("renderer.gameObject.transform.parent.name = " + renderer.gameObject.transform.parent.name);
                if (renderer.gameObject.transform.parent.name == "����")
                {
                    // ���׸����� ���ο� ���׸���� ����
                    renderer.material = newMaterial2;
                }
                if (renderer.gameObject.transform.parent.name == "â��")
                {
                    // ���׸����� ���ο� ���׸���� ����
                    renderer.material = newMaterial;
                }
            }

        }

    }
}