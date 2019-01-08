using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyCollision : MonoBehaviour {

    EnemyMovementController enemyMovement;

    void Start()
    {
        enemyMovement = GetComponent<EnemyMovementController>();
    }

	void OnCollisionEnter(Collision other)
    {
       // Debug.Log("Werewolf collider hit: " + other.gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Werewolf trigger  enter: " + other.name);
           
            enemyMovement.target = other.transform;

             if (Vector3.Distance(transform.position,enemyMovement.target.position) >= 5)
                StartCoroutine(enemyMovement.HowlAnimation());

        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
          //  Debug.Log("Werewolf trigger stay: " + other.name);
            enemyMovement.target = other.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Werewolf trigger exit: " + other.name);
            enemyMovement.target = null;

        }
    }
}
