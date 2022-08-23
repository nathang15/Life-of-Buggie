using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator animator;
    private void Awake(){
        animator = GetComponent<Animator>();
    }
    private void Open(){
        animator.SetTrigger("OpenDoor");
        animator.SetBool("HasOccupant", true);
    }
    void OnTriggerEnter2D (Collider2D other){
        Open();
    }
    void OnTriggerExit2D (Collider2D other){
        animator.SetBool("HasOccupant", false);
    }
}
