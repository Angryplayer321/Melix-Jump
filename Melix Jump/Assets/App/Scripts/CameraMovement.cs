using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform ballTransform;

    [SerializeField] private float offSet;

    private Vector3 currentPosition;

    

    private void LateUpdate()
    {
        if(ballTransform.position.y<(transform.position.y-offSet))
        {
            currentPosition = transform.position;
            currentPosition.y = ballTransform.position.y+offSet;
            transform.position = currentPosition;
        }
    }
}
