using UnityEngine;

public class PillarPart : MonoBehaviour
{
    [SerializeField] float pushPower;
    public Vector2 SpawnPos;
    public Quaternion SpawnRotation;
    GameObject player;
    Rigidbody2D rb2D;
    [SerializeField] Sprite ice, normal;

    void Start()
    {
        SpawnRotation = transform.rotation;
        SpawnPos = transform.position;
        player = GameObject.FindWithTag("Player");
        rb2D = GetComponent<Rigidbody2D>();
    }
    
    void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.transform.parent.gameObject.tag == "Player" && player.GetComponent<SkillCat>().skillOn)
        {
            Vector2 pushDir = new Vector2(transform.position.x, transform.position.y) - other.contacts[0].point;
            print($"{new Vector2(transform.position.x, transform.position.y)}");
            print($"{other.contacts[0].point}");
            print($"{pushDir}");
            pushDir = pushDir.normalized;
            pushDir = new Vector2(pushDir.x*5, pushDir.y);
            print($"{pushDir}");
            rb2D.AddForce(pushDir * pushPower, ForceMode2D.Impulse); 
        }
    }
    
}   
