using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarMovement : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 15f;

    private float axisX;

    // Update is called once per frame
    void Update()
    {
        axisX = Input.GetAxis("Mouse X");

        if (Input.GetMouseButton(0))
        {
            transform.Rotate(0, -axisX * rotationSpeed * Time.deltaTime, 0);
        }
    }
}
