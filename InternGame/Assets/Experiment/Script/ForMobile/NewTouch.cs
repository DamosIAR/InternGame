using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class TouchExample : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    [SerializeField] GameObject Fish;
    GameObject PickedFish;
    [SerializeField] GameObject NotFish;
    GameObject PickedObject;
    bool fishSpawned = false;
    bool objectSpawned = false;
    bool somethingPicked = false;
    void Update()
    {


        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
               if ((hit.collider.tag == "FishBox" && fishSpawned == false) && somethingPicked == false)
                {
                    Vector3 fishSpawnedLocation = new Vector3(-1f, 0.5f , -9.5f);
                    PickedFish = Instantiate(Fish, fishSpawnedLocation , Quaternion.identity);
                    Debug.Log("spawn");
                    fishSpawned = true;
                    somethingPicked = true;
                    
                }
                else if ((hit.collider.tag == "FishBox" && fishSpawned == true) && somethingPicked == true)
                {
                    Destroy(PickedFish);
                    fishSpawned = false;
                    Debug.Log("despawn");
                    somethingPicked= false;
                }

               if ((hit.collider.tag == "Storage" && objectSpawned == false) && somethingPicked == false)
                {
                    Vector3 objectSpawnedLocation = new Vector3(0f, 0.5f, -9.5f);
                    PickedObject = Instantiate(NotFish, objectSpawnedLocation, Quaternion.identity);
                    objectSpawned = true;
                    Debug.Log("Spawned");
                    somethingPicked = true;
                }
               else if ((hit.collider.tag == "Storage" && objectSpawned == true) && somethingPicked == true)
                {
                    Destroy(PickedObject);
                    objectSpawned = false;
                    Debug.Log("despawn");
                    somethingPicked = false;
                }
            }

        }
    }
}