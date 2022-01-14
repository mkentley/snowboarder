using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
[SerializeField] ParticleSystem finishEffect;
[SerializeField] float loadDelay=10.0f;
[SerializeField] string finishSceneName = "FinishScene";

    private const string Message = "You Finished!";

    void OnTriggerEnter2D(Collider2D other)
   {
     if (other.tag == "Player") {
       finishEffect.Play();
       GetComponent<AudioSource>().Play();
       Invoke("finishScene", loadDelay);
     }
   }

  void finishScene() {
   SceneManager.LoadScene(finishSceneName);

}

}

