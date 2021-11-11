using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour{
    //Destroys dog when the ball is caught
    private void OnTriggerEnter(Collider other){
        Destroy(gameObject);
    }
}
