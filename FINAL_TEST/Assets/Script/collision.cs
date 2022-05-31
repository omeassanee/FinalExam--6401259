using UnityEngine;

public class collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.tag == "player")
        {
            Destroy(gameObject);
        }
    }
}
