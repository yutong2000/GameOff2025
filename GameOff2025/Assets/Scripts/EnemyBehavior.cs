using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;

    private GameObject player;
    private Rigidbody2D rb;

    // last viewed position
    private Vector3 savedPosition;

    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void OnDisable()
    {
        savedPosition = transform.position;
    }


    private void FixedUpdate()
    {
        // move towards player
        Vector2 direction = (player.transform.position - transform.position).normalized;

        // Move enemy
        rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);
    }
}
