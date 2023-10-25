using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oving : MonoBehaviour
{
    public float speed = 5f;

    void Start()
    {
        float xx = Random.Range(-3, 3) == 0 ? -1 : 1;
        float yy = Random.Range(-3, 3) == 0 ? -1 : 1;
        float zz = Random.Range(-3, 3) == 0 ? -1 : 1;
        GetComponent<Rigidbody>().velocity = new Vector3(speed * xx, speed * yy, speed * zz);
    }


}
