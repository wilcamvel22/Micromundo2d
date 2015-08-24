using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    #region Atributes
    #region Floats
    public float maxSpeed = 3;
    public float speed = 50f;
    public float jumpPower = 150f;
    #endregion
    #region Booleans
    public bool grounded = true;
    public bool canDoubleJump = true;
    #endregion
    #region States
    public int curHealth;
    public const int maxHealth = 5;
    #endregion
    #region References
    private Rigidbody2D rb2d;
    private Animator anim;
    #endregion
    #endregion

    #region Methods
    // Use this for initialization
	void Start () 
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();

        curHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () 
    {
        anim.SetBool("Grounded", grounded);
        anim.SetFloat("Speed", Mathf.Abs(rb2d.velocity.x));

        if(Input.GetAxis("Horizontal")< -0.1f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        if (Input.GetAxis("Horizontal") > 0.1f)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        if (Input.GetButtonDown("Jump")) 
        {
            if (grounded)
            {
                rb2d.AddForce(Vector2.up * jumpPower);
                canDoubleJump = true;
				anim.SetBool("Grounded", false);
            }
            else
            {
                if (canDoubleJump)
                {
                    canDoubleJump = false;
                    rb2d.velocity = new Vector2(rb2d.velocity.x, 0);
                    rb2d.AddForce(Vector2.up*jumpPower/1.75f);
                }
            }
            
        }
        if (curHealth > maxHealth)
        {
            curHealth = maxHealth;
        }
        if (curHealth <= 0)
        {
            Die();
        }
	}

    void FixedUpdate()
    {
        //Vector3 caseVelocity = rb2d.velocity;
        //caseVelocity.y = rb2d.velocity.y;
        //caseVelocity.z = 0.0f;
        //caseVelocity.x = 0.75f;

        //Fake friction / testing the x velocity for our player
        //if (grounded)
        //{
        //    rb2d.velocity = caseVelocity;
        //}

        //Howing the player
        float h = Input.GetAxis("Horizontal");
        rb2d.AddForce((Vector2.right * speed) * h);

        //Limiting the speed of the player

        if(rb2d.velocity.x > maxSpeed)
        {
            rb2d.velocity = new Vector2(maxSpeed, rb2d.velocity.y);

        }
        if (rb2d.velocity.x < -maxSpeed)
        {
            rb2d.velocity = new Vector2(-maxSpeed, rb2d.velocity.y);
        }

    }

    public void Die()
    {
        //Restart
        Application.LoadLevel (Application.loadedLevel);
    }
    #endregion
}
