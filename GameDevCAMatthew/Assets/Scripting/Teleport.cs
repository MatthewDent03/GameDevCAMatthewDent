using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePlayer;
    public float offsetY = 0.2f;
    Vector3 offsetVector;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger event");
        Debug.Log("Trigger event: " + other.gameObject);
        offsetVector = new Vector3(0f, offsetY, 0f);
        Debug.Log("Player: " + thePlayer.transform.position);
        Debug.Log("Target: " + teleportTarget.transform.position);
        //other.gameObject.transform.position = teleportTarget.transform.position;
        thePlayer.transform.position = teleportTarget.transform.position;
        //Debug.Log("Player after transform: " + thePlayer.transform;
    }

    // Update is called once per frame

}
