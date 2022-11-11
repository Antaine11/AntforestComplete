using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ElephantRandom : MonoBehaviour
{
    private NavMeshAgent nma = null;
    private GameObject[] RandomPoint;
    private int CurrentRandom;

    public int CurentRandom { get; private set; }

    // Start is called before the first frame update
    private void Start()
    {
        nma = this.GetComponent<NavMeshAgent>();
        RandomPoint = GameObject.FindGameObjectsWithTag("RandomPoint");
        Debug.Log("RandomPoints = " + RandomPoint.Length.ToString());
    }

    // Update is called once per frame
    private void Update()
    {
        if (nma.hasPath == false)
        {
            CurrentRandom = Random.Range(0, RandomPoint.Length + 1);
            nma.SetDestination(RandomPoint[CurentRandom].transform.position);
            Debug.Log("Moving to RandomPoint" + CurrentRandom.ToString());

        }

    }

}
