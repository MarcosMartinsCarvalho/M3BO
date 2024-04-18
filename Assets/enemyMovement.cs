using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    public bool closeToPlayer = false;
    private NavMeshAgent agent;
    public int countdown = 0;
    public bool countdownStarted = true;
    public Canvas kusje1;


    void Start()
    {

        Application.targetFrameRate = 60;
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    void Update()
    {
        agent.SetDestination(player.position);

        
    }

    private void OnTriggerEnter(Collider other)
    {
        closeToPlayer = true;
        countdownStarted = true;
        agent.speed = 50;
        agent.acceleration = 50;
        countdown++;
    }

    private void OnTriggerExit(Collider other)
    {

        kusje1.enabled = false;
        closeToPlayer = false;
        agent.speed = 1.5f;
        agent.acceleration = 8;
        countdownStarted = false;
    }
}