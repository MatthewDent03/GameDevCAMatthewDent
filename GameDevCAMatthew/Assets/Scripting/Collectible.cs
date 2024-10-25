using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//allows Unity functions and class systems

public class NewBehaviourScript : MonoBehaviour 
{

    public GameObject CollectibleOnExplorer; //creating a public variable which references the collectible torches
    public static GameObject currentTorch; //creating a variable which references the currently held torch to alternate to 1 only
    void Start()
    {
        CollectibleOnExplorer.SetActive(false); //Deactivates the torch initially held in explorer's hand
    }

    private void OnTriggerStay(Collider other) //event handler for the triggered event code 
    {
        if (other.gameObject.tag == "Player") //compares the game object's tag for the explorer if its Player
        {
            if (Input.GetKey(KeyCode.E))  //Creating a keycode for pressed interaction
            {
                if(currentTorch != null) //Checking if current torch is active
                    currentTorch.SetActive(false); //disable the torch before collecting new one
                currentTorch = CollectibleOnExplorer; //reassigning the value of the current torch to newly picked up one
                currentTorch.SetActive(true); //setting the new torch to be on
                gameObject.SetActive(false);     //deactivating the torch so it cant be collected again
            }
        }
    }

}