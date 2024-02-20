using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SideMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    Vector3 sideMove = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sideMove.x = 1f;
        transform.position += sideMove * moveSpeed * Time.deltaTime;
    }
}
