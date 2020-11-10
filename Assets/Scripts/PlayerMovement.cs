using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    public float speed = 5f;
    private Vector2 movement;
    private Vector2 fixedMovement;
    private float horiz;
    private float vert;
    private bool canMove = true;
    private GameController gC;

    public float rotateSpeed = 45f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject gCO = GameObject.FindWithTag("GameController");
        gC = gCO.GetComponent<GameController>();
    }

    void Update()
    {
        if (canMove == true)
        {
            // Read input
            horiz = Input.GetAxis("Horizontal");
            vert = Input.GetAxis("Vertical");
        }
        //Debug.Log("x: " + horiz + ",y: " + vert);

        movement = new Vector2(horiz, vert);

        //Move the Player
        Rigidbody2D rBody = GetComponent<Rigidbody2D>();
        rBody.velocity = movement * speed;

        if (Input.GetKey("q"))
        {
            transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey("e"))
        {
            transform.Rotate(-Vector3.forward * rotateSpeed * Time.deltaTime);
        }
    }
}