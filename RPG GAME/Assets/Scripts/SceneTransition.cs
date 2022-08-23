using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    // Start is called before the first frame update

    // public string sceneToLoad;
    // public string exitName;

    // public void OnTriggerEnter2D (Collider2D other){
    //     PlayerPrefs.SetString("LastExitName", exitName);
    //     SceneManager.LoadScene(sceneToLoad);
    // }

    public string sceneToLoad;
    public Vector2 playerPosition;
    public VectorValue playerStorage;

    public void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player") && !other.isTrigger){
            playerStorage.initialValue = playerPosition;
            SceneManager.LoadScene(sceneToLoad);
        }
    }
    
}
