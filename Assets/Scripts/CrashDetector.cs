using System.Net;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CrashDetector : MonoBehaviour

{
    [SerializeField] float loadDelay = 1.0f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashfx;
    bool hasCrashed=false;
    void ReloadScene() {
        SceneManager.LoadScene(0);
    }
    // Start is called before the first frame update

    void OnTriggerEnter2D(Collider2D other) {
          if (other.tag == "Ground" && !hasCrashed){
              hasCrashed=true;
              FindObjectOfType<PlayerControl>().DisableControls();
              crashEffect.Play();
              GetComponent<AudioSource>().PlayOneShot(crashfx);
              Invoke("ReloadScene", loadDelay);
        
      }
    }

}
