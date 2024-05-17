using UnityEngine;

public class test : MonoBehaviour
{
    Rigidbody2D rb2D;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.AddForce(new Vector2(-0.35f, -0.94f)*50f, ForceMode2D.Impulse);
    }

    void Update()
    {
        
    }
}
