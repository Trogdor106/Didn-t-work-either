using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateCheckpoint : MonoBehaviour
{
    public Transform checkpoint;
    public Transform character;
    bool isCheckpointActivated = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other == character) //If player enters checkpoint trigger, set their respawn to that location
        {
            character.GetComponent<CharacterControl>().respawnLoc = checkpoint;
        }
    }
}
