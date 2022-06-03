using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowingTimer : MonoBehaviour
{
    [SerializeField] Renderer myLight;

    private void Start()
    {
        BlinkyLight();
    }
    IEnumerator BlinkyLight()
    {
        yield return new WaitForSeconds(10);
        myLight.enabled = false;
        yield return new WaitForSeconds(10);
        myLight.enabled = true;
    }
}
