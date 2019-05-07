using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject pl;
    public Transform[] target;
    public float rap;
    private int curr;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position != target[curr].position)
        {
            Vector3 tar = Vector3.MoveTowards(transform.position, target[curr].position, rap * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(tar);
        }
        else
        {
            curr = (curr + 1) % target.Length;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
                Destroy(pl);
            
        }
    }
}
