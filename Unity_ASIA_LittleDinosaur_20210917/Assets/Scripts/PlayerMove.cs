using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 PlayerMove = transform.position;
        PlayerMove.x = PlayerMove.x + Input.GetAxis("Horizontal") * moveSpeed;

        transform.position = PlayerMove;
    }
}
