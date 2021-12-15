using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallFromMap : MonoBehaviour
{
    public int FallHeight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        // check if the player fell down
        if (transform.position.y <= FallHeight)
        {
            SceneManager.LoadScene(1); // go to the TryAgainScene

        }
    }
}
