using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;
using UnityEngine.VFX;

public class FireCanon : MonoBehaviour
{
    [SerializeField] private Transform shootPoint;
    [SerializeField] private GameObject projectile;
    [SerializeField] private VisualEffect flash;
    [SerializeField] private ParticleSystem explosionImpact;
    [SerializeField] private bool autoShoot;
    private ParticleSystem explosionImpact1;
    private VisualEffect flash1;
    private GameObject projectile1;
    private float timer;


    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetMouseButtonDown(3))
        {
            ShootingEffects();
        }

        if (autoShoot && timer >= 3)
        {
            ShootingEffects();
            timer = 0;
        }
    }

    private void ShootingEffects()
    {
        flash1 = Instantiate(flash, shootPoint.transform.position, Quaternion.identity);
        flash1.transform.position = shootPoint.position;
        flash1.Play();
        ShootProjectile();
        Destroy(flash1, 5);
    }

    private void ShootProjectile()
    {
        float randomSpeed = Random.Range(20, 30);
        projectile1 = Instantiate(projectile, shootPoint.position, shootPoint.rotation);
        projectile1.GetComponent<Rigidbody>().AddForce(randomSpeed * new Vector3(Random.Range(-1,1), 1, 1).normalized, ForceMode.Impulse);
    }
}
