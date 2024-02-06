using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // Movement
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if collided with an item
        if (other.CompareTag("Item"))
        {
            // Do something with the item (e.g., collect it)
            CollectItem(other.gameObject);
        }
    }

    void CollectItem(GameObject item)
    {
        // Add your logic for collecting items here
        Debug.Log("Collected item: " + item.name);
        // You can deactivate
    }
}
