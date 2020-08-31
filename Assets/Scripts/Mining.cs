using System;
using System.Collections;
using UnityEngine;

public class Mining : MonoBehaviour
{
    public GameObject player;
    public GameObject rockItem;
    public float proximity;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (((Vector3.Distance(transform.position, player.transform.position)) < proximity) && (Input.GetKey(KeyCode.Space)))
        {
            Instantiate(rockItem, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }



}
