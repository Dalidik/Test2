using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] obj;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randomIndex = Random.Range(0, obj.Length);
            Vector3 randomPos = new Vector3(Random.Range(-3, 4), 1, Random.Range(-3, 4));

            Instantiate(obj[randomIndex], randomPos, Quaternion.identity);
        }
    }

}
