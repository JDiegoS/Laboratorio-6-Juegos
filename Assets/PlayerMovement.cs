using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour { 

    public GameObject pl;
    public Camera cam;
    public NavMeshAgent ag;
    // Start is called before the first frame update
    void Start()
    {
        //sonido = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray =cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                ag.SetDestination(hit.point);
            }
        }


    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(pl);
        }

    }

}
