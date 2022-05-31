using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public float speed;
    [SerializeField] Rigidbody2D rb;
    float MoveX;
    float MoveY;
    private Vector2 movement;
    public GameObject enemy;
    public GameObject plusfive;
    public Text scoretext;
    int scoreint;
    string scorestring;

    private void Start()
    {
        
    }

    void Update()
    {
        movemento();
        textupdate();
    }

    private void FixedUpdate()
    {
         rb.velocity = movement * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "enemy")
        {         
            scoreint--;            
        }
        if (collision.collider.tag == "plusfive")
        {          
            scoreint = scoreint + 5;          
        }
       
       
    }

    void movemento()
    {
        movement = new Vector2(MoveX, MoveY);

        if (Input.GetKey(KeyCode.A))
        {
            MoveX = -1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            MoveX = 1;
        }

        if (Input.GetKey(KeyCode.W))
        {
            MoveY = 1;
        }

        if (Input.GetKey(KeyCode.S))
        {
            MoveY = -1;
        }
    }
    void textupdate()
    {
        scorestring = scoreint.ToString();
        scoretext.text = scorestring;   
    }
}
