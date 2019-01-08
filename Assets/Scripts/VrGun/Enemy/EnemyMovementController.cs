using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovementController : MonoBehaviour {

    public NavMeshAgent agent;
    public Transform target;
    public List<Transform> patrolPoints;
    public int nextPortolPoint;

    public bool isHowling;

    AudioSource werewolfAudioSource;

	void Start ()
    {
        agent = GetComponent<NavMeshAgent>();
        nextPortolPoint = 0;
        werewolfAudioSource = GetComponent<AudioSource>();
        isHowling = false;
	}
	
	void Update ()
    {
        if (target != null)
        {
            if(agent.isActiveAndEnabled)
            agent.SetDestination(target.position);

            if (Vector3.Distance(transform.position, target.position) <= 3)
                GetComponent<Animator>().SetBool("isAttacking", true);
        }

        else
        {
            
            if (Vector3.Distance(transform.position, patrolPoints[nextPortolPoint].position) <= 3)
                nextPortolPoint = Random.Range(0, patrolPoints.Count);

            agent.SetDestination(patrolPoints[nextPortolPoint].position);

            if(GetComponent<Animator>().GetBool("isAttacking"))
            GetComponent<Animator>().SetBool("isAttacking", false);
        }

    }

   public IEnumerator  HowlAnimation()
    {
        isHowling = true;
        werewolfAudioSource.Play();
        agent.enabled = false;
        GetComponent<Animator>().SetBool("isHowling", isHowling);
        Debug.Log("start howl");
        yield return new WaitForSeconds(2.5f);
        isHowling = false;
        GetComponent<Animator>().SetBool("isHowling", isHowling);
        agent.enabled = true;
        Debug.Log("end howl");
    }
}
