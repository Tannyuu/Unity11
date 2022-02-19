using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform player;

    public float traceDist = 10.0f;
    NavMeshAgent nav;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();

        StartCoroutine(CheckDist());
    }

    IEnumerator CheckDist()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.2f);//1秒間に5回処理をする

            float dist = Vector3.Distance(player.position, transform.position);//敵と自分の距離

            if(dist < traceDist)
            {
                nav.SetDestination(player.position);//目的地

                nav.isStopped = false;
            }
            else
            {
                nav.isStopped = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
