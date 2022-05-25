using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swing : MonoBehaviour
{
    Collision collision;
    //public ParticleSystem particlesystem;
    public bool hit;
    //private animator animator;
    public float timeStop = 1;
    public bool ableToHit;

    // Start is called before the first frame update
    void Start()
    {
        ableToHit = true;
        //animator = GetComponent<Animator>();
        hit = false;
        //particlesystem.Stop();
        
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
            if (other.gameObject.tag == "enemy")
            {
                hit = true;
                //particlesystem.Play();
                //animator.SetBool("hit", true);
                Debug.Log(ableToHit);
                if (ableToHit == true)
                {
                    Debug.Log(ableToHit);
                    ableToHit = false;
                }
                StartCoroutine(particlestop(timeStop));
            }
    }

    IEnumerator particlestop(float time)
    {
        yield return new WaitForSeconds(time);
        //particlesystem.Stop();
    }
}
