using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class LaunchParticle : MonoBehaviour
{
    [SerializeField] private ParticleSystem explosion;
    [SerializeField] private GameObject groundCrack;
    private ParticleSystem explosion1;
    private GameObject groundCrack1;

    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Floor"))
        {
            groundCrack1 = Instantiate(groundCrack,this.transform.position,Quaternion.identity);
            explosion1 = Instantiate(explosion,this.transform.position, Quaternion.identity);
            //explosion1.transform.position = this.transform.position;
            explosion1.Play();
            CameraShaker.Invoke();
            Destroy(gameObject);
        }
    }
}
