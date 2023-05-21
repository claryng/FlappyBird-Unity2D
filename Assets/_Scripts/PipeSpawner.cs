using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject Pipe;
    public float SpawnRate = 2;
    private float _timer = 0;
    private float _pipeDifference = 10;

    // Start is called before the first frame update
    private void Start()
    {
        Spawner();
    }
    
    // Update is called once per frame
    private void Update()
    {
        if(_timer < SpawnRate)
        {
            _timer += Time.deltaTime;
        }
        else
        {
            Spawner();
            _timer = 0;
        }
    }
    private void Spawner()
    {
        float highest = transform.position.y + _pipeDifference;
        float lowest = transform.position.y - _pipeDifference;

        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(highest,lowest), 0), transform.rotation);
    }
}
