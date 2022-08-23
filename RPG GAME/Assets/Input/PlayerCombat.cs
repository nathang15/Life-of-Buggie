using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerCombat : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerInputs controls;
    private InputAction hit;
    private Animator animator;
    private void Awake(){
        animator = GetComponent<Animator>();
        controls = new PlayerInputs();
        
    }
    private void Hitting(InputAction.CallbackContext context){
        animator.SetTrigger("Hit"); 
        
    }

    private void OnEnable(){
        hit = controls.InGame.IsHit;
        hit.Enable();
        hit.performed += Hitting;
 
    }
    private void OnDisable(){
        hit.Disable();
    } 
}
