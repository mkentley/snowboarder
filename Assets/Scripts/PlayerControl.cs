using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
 [SerializeField] float torqueAmount = 1f;
 [SerializeField] float baseSpeed=3f;
 [SerializeField] float boostSpeed = 10f;

    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
    // Start is called before the first frame update
    void Start()
    {
     rb2d = GetComponent<Rigidbody2D>();  
     surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        RespondToBoost();
    }

    void RespondToBoost() {

    
    if (Input.GetKey(KeyCode.UpArrow)) {
surfaceEffector2D.speed = boostSpeed;
    } else {
        surfaceEffector2D.speed = baseSpeed;
    }
    

    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        { rb2d.AddTorque(-torqueAmount); }
    }
}
