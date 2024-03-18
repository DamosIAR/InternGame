using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField] private KitchenObject kitchenObject;
    [SerializeField] private Transform BoxTopPoint;

    public void interact()
    {
        Debug.Log("hit");
        Transform ObjectTransform = Instantiate(kitchenObject.prefab, BoxTopPoint);
        ObjectTransform.localPosition = Vector3.zero;
    }
}
