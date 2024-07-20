using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3;

    void Start()
    {
        
    }

    void Update()
    {
        PlayerMovement();
        PlayerRotatiom();
    }

    void PlayerMovement()
		{
        Vector2 move;
        move.y = Input.GetAxis("Vertical");
        move.x = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(move.x, 0, move.y) * Time.deltaTime * moveSpeed, Space.World);
    }
    void PlayerRotatiom()
		{
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
				{
            transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
				}
		}
}
