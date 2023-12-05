using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25,0,0);
    // Start is called before the first frame update
    void Start()
    {
       Instantiate(obstaclePrefab,spawnPos,obstaclePrefab.transform.rotation); 
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
