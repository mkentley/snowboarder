using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
[SerializeField] float loadDelay=2.0f;
    private const string Message = "You Finished!";

    void OnTriggerEnter2D(Collider2D other)
   {
     if (other.tag == "Player") {
       Invoke("reloadScene", loadDelay);
     }
   }

  void reloadScene() {
   SceneManager.LoadScene(0);


}

}

