using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntranceScene : MonoBehaviour
{


    public string lastExitName;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetString("LastExitName") == lastExitName){
            PlayerManager.instance.transform.position = transform.position;
        }
    }
}
