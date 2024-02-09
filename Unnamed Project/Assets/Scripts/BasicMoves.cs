using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMoves : MonoBehaviour
{
    private Rigidbody2D rbPlayer;
    public float speed = 1f;

    Vector2 movimento;

    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();

        //if()
    }

    // Update is called once per frame
    void Update()
    {
        movimento.x = Input.GetAxis("Horizontal");
        movimento.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        //rbPlayer.MovePosition()
    }
}
