using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float moveSpeed;
    public float deadZone = -40;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <= deadZone)
        {
            Destroy(gameObject);
        }
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;
    }
}
