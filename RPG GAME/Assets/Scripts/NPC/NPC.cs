using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private Vector3 directionVectorNPC;
    private Transform myTransformNPC;
    public float speedNPC;

    private Rigidbody2D myRigidbodyNPC;
    private Animator animNPC;
    public Collider2D boundsNPC;
    // Start is called before the first frame update
    void Start()
    
    {
        animNPC = GetComponent<Animator>();
        myTransformNPC = GetComponent<Transform>();
        myRigidbodyNPC = GetComponent<Rigidbody2D>();
        ChangeDirectionNPC();
    }
    

    // Update is called once per frame
    void Update()
    {
        MoveNPC();
    }
    private void MoveNPC(){
        Vector3 tempNPC = myTransformNPC.position + directionVectorNPC * speedNPC * Time.deltaTime;
        if (boundsNPC.bounds.Contains(tempNPC)){
            myRigidbodyNPC.MovePosition(tempNPC);
        }
        else{
            ChangeDirectionNPC();
        }
    }
    void ChangeDirectionNPC(){
        int directionNPC = Random.Range(0, 4);
        switch(directionNPC)
        {
            case 0: 
                directionVectorNPC = Vector3.right;
                break;

            case 1:
                directionVectorNPC = Vector3.left;
                break;
            case 2:
                directionVectorNPC = Vector3.up;
                break;
            case 3:
                directionVectorNPC = Vector3.down;
                break;
            default:
                break;
        }
        UpdateAnimationNPC();
    }

    void UpdateAnimationNPC(){
        animNPC.SetFloat("MoveX", directionVectorNPC.x);
        animNPC.SetFloat("MoveY", directionVectorNPC.y);
    }
}
