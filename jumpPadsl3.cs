using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpPadsl3 : MonoBehaviour
{
    private float jumpForce = 3f;
    public GameObject player;
    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // if the player touches the jump pad
            player = collision.gameObject;

            player.GetComponent<Rigidbody>().AddForce(new Vector3(player.GetComponent<Rigidbody>().velocity.x, 12, player.GetComponent<Rigidbody>().velocity.z) * jumpForce, ForceMode.VelocityChange);
        }
    }
}
