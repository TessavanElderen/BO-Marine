using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPointer : MonoBehaviour
{
    [SerializeField] float range = 100;

    void Start()
    {
        
    }

    void Update()
    {
        Pointer();
    }

    void Pointer()
    {
        Debug.DrawRay(transform.position, transform.forward * range, Color.red);
    }
}