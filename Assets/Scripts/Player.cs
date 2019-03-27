using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject WallBounceEffectObj;

    Rigidbody2D rigidBody;

    [SerializeField] int JumpX = 10;
    [SerializeField] int JumpY = 10;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (rigidBody.velocity.x > 0)
            {
                rigidBody.velocity = new Vector2(JumpX, JumpY);
            }
            else
            {
                rigidBody.velocity = new Vector2(-JumpX, JumpY);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Walls")
        {
            GameObject effect = Instantiate(WallBounceEffectObj, collision.contacts[0].point, Quaternion.identity);

            Destroy(effect, 0.5f);
        }

        
    }
}
