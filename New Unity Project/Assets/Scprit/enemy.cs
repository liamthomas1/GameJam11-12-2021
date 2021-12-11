using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Accessibility;
public class enemy : MonoBehaviour
{
    public NavMeshAgent agents;
    public Transform player;
    public LayerMask whatisground, whatisplayer;
    //patroling
    public Vector3 walkpoint;
    bool walkpointset;
    public float walkpointrange;

    //attacking
    public float TimeBetweenAttacks;
    bool alreadyAttacks;
    //states
    public float sightrange, attackrange;
    public bool playerinsightrange, playerinattackedrange;
    private void Awake()
    {
        player = GameObject.Find("playerobj").transform;
        agents = GetComponent<NavMeshAgent>();
    }

}
