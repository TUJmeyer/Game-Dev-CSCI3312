using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    private CircleCollider2D cc;
    public LayerMask platformMask;
    public float speed = 5f;
    [SerializeField] private float jumpVelocity = 50f;
    private Vector2 respawnPt;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cc = GetComponent<CircleCollider2D>();
        respawnPt = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        //float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);

        if(isGround() && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space pressed");
            rb.velocity = Vector2.up * jumpVelocity;
        }
    }

    private bool isGround()
    {
        RaycastHit2D raycastHit2D = Physics2D.CircleCast(cc.bounds.center, cc.radius, Vector2.down, .01f, platformMask);
        return raycastHit2D.collider != null;
    }

    void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if("Respawn".Equals(collision.gameObject.tag))
        {
            Debug.Log("Died");
            transform.position = respawnPt;
        }
    }
}
