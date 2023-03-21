using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//public class PickUpBozos : MonoBehaviour
{/*
    public Transform PickUpPoint;
    public Transform Player;

    public float picKupdistance;
    public float forceMultiplier;

    public bool ReadyToThrow;
    public bool ItemIsPicked;

    private Rigidbody rb;

    private NavMeshAgent navMeshAgent;

    //attempt to stop the AI movement
    public bool disableScript = false;
    public WonderAI wonderAiScript;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Player = GameObject.Find("ChunLi").transform;
        PickUpPoint = GameObject.Find("PickUpPoint").transform;

        // Get the NavMeshAgent component attached to this GameObject
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // Disable the script component if disableScript is true
        if (disableScript)
        {
            // Disable the script component attached to this GameObject
            wonderAiScript.enabled = false;
        }
        //above this comment is a whack attempt to disable ai roaming


        if (Input.GetKey(KeyCode.F) && ItemIsPicked == true && ReadyToThrow)
        {
            forceMultiplier += 300 * Time.deltaTime;
            // Disable the NavMeshAgent component
            //navMeshAgent.enabled = false;
            // wonderAiScript.enabled = false;
        }

        picKupdistance = Vector3.Distance(Player.position, transform.position);

        if (picKupdistance <= 2)
        {
            if (Input.GetKeyDown(KeyCode.F) && ItemIsPicked == false && PickUpPoint.childCount < 1)
            {
                GetComponent<Rigidbody>().useGravity = false;
                GetComponent<BoxCollider>().enabled = false;
                this.transform.position = PickUpPoint.position;
                this.transform.parent = GameObject.Find("PickUpPoint").transform;

                ItemIsPicked = true;
                forceMultiplier = 0;

                // Disable the NavMeshAgent component
                // navMeshAgent.enabled = false;
                disableScript = true;
            }
        }
        if (Input.GetKeyUp(KeyCode.F) && ItemIsPicked == true)
        {
            ReadyToThrow = true;

            if (forceMultiplier > 10)
            {
                rb.AddForce(Player.transform.forward * forceMultiplier);
                this.transform.parent = null;
                GetComponent<Rigidbody>().useGravity = true;
                GetComponent<BoxCollider>().enabled = true;
                ItemIsPicked = false;
            }
            forceMultiplier = 0;
        }
    }*/
}