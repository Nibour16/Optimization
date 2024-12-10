using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGenerator : MonoBehaviour
{
    [SerializeField] private GameObject spawningObj;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(spawningObj, transform.position, Quaternion.identity);
        }
    }
}
