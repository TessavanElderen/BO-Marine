using System.Collections;
using UnityEngine;

public class schieten : MonoBehaviour
{
    internal float damage = 10f;
    internal float range = 100f;
    internal float impactForce = 60f;
    private int kogels = 3;
    private bool kanVuren = false;
    private float timer = 2f;

    [SerializeField] Camera fpsCam;
    [SerializeField] ParticleSystem flash;
    [SerializeField] ParticleSystem blood;


    void Update()
    {
        

        if (kanVuren == true && kogels > 0 && Input.GetButtonDown("Fire2"))
        {
            shoot();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            kanVuren = true;
        }

        if(kogels < 2)
        {
            reload();
        }

    }

    private void shoot()
    {

        flash.Play();

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            target target = hit.transform.GetComponent<target>();
            if(target != null)
            {
                target.takeDamage(damage);
            }

            Instantiate(blood, hit.point, Quaternion.LookRotation(hit.normal));
        }
        kogels--;
    }

    private void reload()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            kogels++;
            timer = 2f;
        }
    }

}
