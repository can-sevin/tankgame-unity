using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TankAI : MonoBehaviour {

    public Transform[] waypointsTransform;
    Vector3[] points;
    Animator fsmAI;
    public Transform playerTank;
    int currentIndex = 0;
    float maxCheckDistance = 10;
    NavMeshAgent agent;


	// Use this for initialization
	void Start () {
        points = new Vector3[2];
        agent = GetComponent<NavMeshAgent>();
        fsmAI = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        points[0] = waypointsTransform[0].position;
        points[1] = waypointsTransform[1].position;
        Vector3 dir = (playerTank.position - transform.position).normalized;
        float distance = Vector3.Distance(playerTank.position, transform.position);
        fsmAI.SetFloat("distance", distance);

        float distanceFromWayPoint = Vector3.Distance(points[currentIndex], transform.position);
        fsmAI.SetFloat("distancefromwaypoint",distanceFromWayPoint);

        Ray ray = new Ray(transform.position, dir);


        Debug.DrawRay(ray.origin, ray.direction * maxCheckDistance * 10, Color.red);

        if (Physics.Raycast(ray,maxCheckDistance * 10))
        {
            fsmAI.SetBool("isVisible", true);
        }
        else
        {
            fsmAI.SetBool("isVisible", false);
        }
        agent.SetDestination(points[currentIndex]);

    }

    public void FindNewWayPoint()
    {
        switch(currentIndex)
        {
            case 0:
                currentIndex = 1;
                break;
            case 1:
                currentIndex = 0;
                break;
        }
    }

    public void Chase()
    {
        Debug.Log("Chasing");
    }

    public void Shoot()
    {
        Debug.Log("Shooting");
    }

    public void Patrol()
    {
        Debug.Log("Patrolling");
    }
}
