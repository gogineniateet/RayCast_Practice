using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController controller;
    public float playerSpeed;
    public Transform rayPoint;


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inoutZ = Input.GetAxis("Vertical");

        Vector3 move = transform.right * inputX + transform.forward * inoutZ;
        controller.Move(move * playerSpeed * Time.deltaTime);
        if(Input.GetMouseButtonDown(0))
        {
            Hit();
        }
    }

    private void Hit()
    {
        RaycastHit hitInfo;
        if (Physics.Raycast(rayPoint.position, rayPoint.forward, out hitInfo, 100f))
        {
            GameObject hitZombie = hitInfo.collider.gameObject;
            if (hitZombie.tag == "Obstacle")
            {
                Destroy(hitZombie);
            }
        }
    }
}
