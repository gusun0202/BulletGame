using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatPlayerCS : MonoBehaviour
{
    Rigidbody rigid;
    void Start()
    {
        rigid = GetComponent<Rigodbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey.KeyCode.UpArrow)) {
            Debug.Log("앞으로~");
            transform.position = new Vector3(
            transform.position.x
            , transform.position.y
            , transform.position.z + 3f * Time.delaTime
            );
        }
        if (input.GetKay(KeyCode.DownArrow)) {
            Debug.Log("뒤로~");
            transform.position = new Vector3(
            transform.position.x
            , transform.position.y
            , transform.position.z - 3f * Time.delaTime
            );
        }

    }
}
