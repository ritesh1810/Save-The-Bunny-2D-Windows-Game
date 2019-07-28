using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb;

    float xInput;

    public float moveSpeed;

    public float xPositionLimit;

    Vector2 newPosition;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        // -1 to +1 
        xInput = Input.GetAxis("Horizontal");

        newPosition = transform.position;

        //newPosition.x = newPosition.x + xInput;
        newPosition.x += xInput * moveSpeed;

        newPosition.x = Mathf.Clamp(newPosition.x, -xPositionLimit, xPositionLimit);

        rb.MovePosition(newPosition);
    }


}
