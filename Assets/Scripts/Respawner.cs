using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    public Transform character;
    public Transform respawnLoc;
    private void OnTriggerEnter(Collider other)
    {
       // character.getComponent<CharacterControl>().respawnLoc = other.transform.position;
        character.transform.position = character.GetComponent<CharacterControl>().respawnLoc.transform.position;
        //character.transform.position = respawnLoc.transform.position;
    }
}
