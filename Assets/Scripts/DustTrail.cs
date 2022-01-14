using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] ParticleSystem dustParticles;

     void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Ground")
        dustParticles.Play();
    }

     void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.tag == "Ground")
        dustParticles.Stop();
    }
}
