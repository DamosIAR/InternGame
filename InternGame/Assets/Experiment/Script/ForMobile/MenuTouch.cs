using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuTouch : MonoBehaviour
{
    private AnimationManager anim;
    public Camera mainCamera;

    private void Start()
    {
        anim = GameObject.FindGameObjectWithTag("Start").GetComponent<AnimationManager>();
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Start")
                {
                    Debug.Log(tag);
                    anim.startButton();
                    
                }
                
            }
        }
    }

    
}
