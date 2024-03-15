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
    public Canvas kusje;
    

    void Start()
    {
        kusje = gameObject.GetComponent<Canvas> ();
        Application.targetFrameRate = 60;
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    void Update()
    {
        agent.SetDestination(player.position);

        if (countdownStarted)
        {
            countdown++;
        }

        if (countdown >= 400)
        {
            countdown = 0;
        }

        if (countdown >= 179)
        {
            kusje.GetComponent<Canvas>().enabled = true;
        }
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
        closeToPlayer = false;
        agent.speed = 3.5f;
        agent.acceleration = 8;
        countdownStarted = false;
    }
}
