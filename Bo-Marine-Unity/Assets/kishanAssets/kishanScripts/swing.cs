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
        if (Input.GetMouseButtonDown(0))
        {
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        target target = other.transform.GetComponent<target>();
        if (other.gameObject.tag == "enemy")
            {
                hit = true;
                particlesystem.Play();
                animator.SetBool("hit", true);
                Debug.Log(ableToHit);
                if (ableToHit == true)
                {
                    Debug.Log(ableToHit);
                    ableToHit = false;
                }
                StartCoroutine(particlestop(timeStop));
                target.takeDamage(damage);
            }
    }

    IEnumerator particlestop(float time)
    {
        yield return new WaitForSeconds(time);
        particlesystem.Stop();
    }
}
