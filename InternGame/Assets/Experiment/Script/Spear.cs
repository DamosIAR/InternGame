using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : MonoBehaviour
{
    ScoreManager scoreManager;
    public float force;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GetComponent<ScoreManager>();
        Vector3 direction = transform.position;
        //Vector3 height = transform.position.y;
        transform.rotation = Quaternion.Euler(90, 0, 0);
        rb.velocity = new Vector3(0, -direction.y).normalized * force;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Object")
        {
            Debug.Log("UANG");
            scoreManager.updateScore();
            Destroy(gameObject);
        }
    }
}