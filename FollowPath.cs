//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    //Waypoint array
    [SerializeField]
    private Transform[] waypoints;

    //Walk speed (Set in Inspector)
    [SerializeField]
    private float moveSpeed = 2f;

    //Current waypoint index
    private int wpI = 0;

    //Init
    private void Start(){

        //set enemy pos (first wp, might need to change this when merging to select)
        transform.position = waypoints[wpI].transform.position;
    }
    // Update is called once per frame
    private void Update(){
        //Move enemy
        Move();
    }

    //actual movement
    private void Move(){
        //If enemy didn't reach last waypoint, move
        //If enemy reached alst waypoint, stop
        if(wpI <= waypoints.Length - 1){
            //move from current wp to next using MoveTowards method
            transform.position = Vector3.MoveTowards(transform.position, waypoints[wpI].transform.position, moveSpeed * Time.deltaTime);

            //If enemy reches waypoint, increase index by 1
            if(transform.position == waypoints[wpI].transform.position){
                wpI += 1;
            }
        }
    }
}
