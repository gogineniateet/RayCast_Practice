using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController controller;
    public float playerSpeed;


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
    }
}
