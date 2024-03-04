using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class TouchExample : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    [SerializeField] GameObject Fish;
    GameObject PickedFish;
    bool fishSpawned = false;
    [SerializeField] GameObject Prawn;
    GameObject PickedPrawn;
    bool prawnSpawned = false;
    [SerializeField] GameObject Squid;
    GameObject PickedSquid;
    bool squidSpawned = false;

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
                    Vector3 fishSpawnedLocation = new Vector3(2.5f, 1f, -10f);
                    PickedFish = Instantiate(Fish, fishSpawnedLocation , Quaternion.identity);
                    Debug.Log("Fish spawn");
                    fishSpawned = true;
                    somethingPicked = true;
                    
                }
                else if ((hit.collider.tag == "FishBox" && fishSpawned == true) && somethingPicked == true)
                {
                    Destroy(PickedFish);
                    fishSpawned = false;
                    Debug.Log("Fish despawn");
                    somethingPicked= false;
                }

               if ((hit.collider.tag == "ShrimpBox" && prawnSpawned == false) && somethingPicked == false)
                {
                    Vector3 PrawnSpawnedLocation = new Vector3(-2f, 1f, -10f);
                    PickedPrawn = Instantiate(Prawn, PrawnSpawnedLocation, Quaternion.identity);
                    prawnSpawned = true;
                    Debug.Log("Prawn Spawned");
                    somethingPicked = true;
                }
               else if ((hit.collider.tag == "ShrimpBox" && prawnSpawned == true) && somethingPicked == true)
                {
                    Destroy(PickedPrawn);
                    prawnSpawned = false;
                    Debug.Log("Prawn despawn");
                    somethingPicked = false;
                }

               if ((hit.collider.tag == "SquidBox" && squidSpawned == false) && somethingPicked == false )
                {
                    Vector3 squidSpawnedLocation = new Vector3(6.5f, 1f, -10f);
                    PickedSquid = Instantiate(Squid, squidSpawnedLocation, Quaternion.identity);
                    squidSpawned = true;
                    Debug.Log("Squid Spawn");
                    somethingPicked = true;
                }
               else if ((hit.collider.tag == "SquidBox" && squidSpawned == true) && somethingPicked == true)
                {
                    Destroy(PickedSquid);
                    squidSpawned = false;
                    Debug.Log("Squid despawn");
                    somethingPicked = false;
                }
            }

        }
    }
}