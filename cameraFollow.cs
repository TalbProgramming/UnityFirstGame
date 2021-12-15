using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //camera rotation set to(30.542, 0.485, 0)
        transform.position = target.position + new Vector3(0, 7, -10);
        transform.LookAt(target);
    }
}
