using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class opossum : MonoBehaviour
{


    [SerializeField]
    Transform CastPoint;


    [SerializeField]
    Transform Player;

    [SerializeField]
    float agroRange;


    [SerializeField]

    float moveSpeed;

    Rigidbody2D rbd2;


    bool isFacingRight;


    void Start()
    {

        rbd2 = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        // distance to player 

        float distToPlayer = Vector2.Distance(transform.position, Player.position);

        if (distToPlayer < agroRange)

        {
            //chase player
            ChasePlayer();
        }

        else
        {
            //stop chasing player 
            StopChasingPlayer();
        }

        //if (CanSeePlayer(agroRange))
        // {

        // ChasePlayer();
        // }

        // else
        // {
        // StopChasingPlayer();
        // }

    }

    //bool CanSeePlayer (float distance)
    // {
    //bool val = false;
    //  float castDist = distance;


    // Vector2 endPos = CastPoint.position + Vector3.right * distance;

    // RaycastHit2D hit = Physics2D.Linecast(CastPoint.position , endPos, 1 << LayerMask.NameToLayer("Action"));

    //  if (hit.collider != null)
    // {

    //   if (hit.collider.gameObject.CompareTag("Player"))
    //   {
    //val = true;
    //}
    //  else
    //  {
    //val = false;
    //  }

    //Debug.DrawLine(CastPoint.position, endPos, Color.blue);

    //}

    // return val;
    //}

    void ChasePlayer()
    {

        if(transform.position.x< Player.position.x)
        {
                       //move right
            rbd2.velocity = new Vector2(moveSpeed, 0);
            transform.localScale = new Vector2(-1, 1);

        }

        else 
        {
                      //move left 
            rbd2.velocity = new Vector2(-moveSpeed, 0);
          
        }


    }

      void StopChasingPlayer()
       {



        rbd2.velocity = Vector2.zero;

       }

  

}


