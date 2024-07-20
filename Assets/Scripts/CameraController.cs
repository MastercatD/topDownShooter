using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] private Transform target;
    [SerializeField] private Vector3 targetOffset;
    [SerializeField] private float cameraSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        CameraMovement();
    }
    void CameraMovement()
		{
        transform.position = Vector3.Lerp(transform.position, target.position + targetOffset, cameraSpeed * Time.deltaTime);
		}
}
