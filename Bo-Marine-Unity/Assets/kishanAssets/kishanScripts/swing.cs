using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swing : MonoBehaviour
{
    Collision collision;
    [SerializeField] ParticleSystem particlesystem;
    internal bool hit;
    [SerializeField] Animator animator;
    private float timeStop = 1;
    private bool ableToHit;
    internal float damage = 10f;

    void Start()
    {
        ableToHit = true;
        animator = GetComponent<Animator>();
        hit = false;
        particlesystem.Stop();
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            animator.SetBool("hit", true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        target target = other.transform.GetComponent<target>();
        if (other.gameObject.tag == "enemy")
        {
            hit = true;
            particlesystem.Play();
            Debug.Log(ableToHit);
            if (ableToHit == true)
            {
                Debug.Log(ableToHit);
                ableToHit = false;
            }
            target.takeDamage(damage);
        }
    }
}
