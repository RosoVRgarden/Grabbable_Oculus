using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    public Animator myAnimationController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) { 

            myAnimationController.SetBool("sphere", true);
            print("open door...");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")){

            myAnimationController.SetBool("sphere", false);
            print("close door...");
        }
    }
   
}
