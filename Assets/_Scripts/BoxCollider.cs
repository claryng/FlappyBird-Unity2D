using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCollider : MonoBehaviour
{
    public LogicManager logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3 && !logic.gameOverText.activeSelf)
        {
            logic.addScore(1);
        }
    }
}
