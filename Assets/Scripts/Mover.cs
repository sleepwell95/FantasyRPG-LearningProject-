using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; //Geting AI library to use NavMesh

public class Mover : MonoBehaviour {
    [SerializeField] Transform target; //Assigning the target that we want to move to

    // Update is called once per frame
    void Update () {
        GetComponent<NavMeshAgent> ().destination = target.position;
        //Geting NavMesh on GameObject and assigning its destination position
        //Then Player moves to target position.
    }
}