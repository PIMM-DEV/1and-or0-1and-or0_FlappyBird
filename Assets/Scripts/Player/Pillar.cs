using UnityEngine;

public class Pillar : MonoBehaviour
{
    [SerializeField] GameObject pillarM, player, pillarIceLow, pillarIceHigh, pillarNormalLow, pillarNormalHigh, pillarStreet;
    public float speed;
    [SerializeField] float y_min, y_max; // 5 10 -1f 3f
    [SerializeField] float despawn_x; // -5
    [SerializeField] bool notPushing;
    // Rigidbody2D rb2D;
    void Awake()
    {
        notPushing= true;
        pillarM = GameObject.FindWithTag("PillarManager");
        player = GameObject.FindWithTag("Player");
        // rb2D = GetComponent<Rigidbody2D>();
    }

    void OnEnable()
    {
        float rand_y = Random.Range(y_min, y_max);
        transform.position = new Vector3(transform.position.x, rand_y, transform.position.z);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && player.GetComponent<SkillCat>().skillOn)
        {
            notPushing = false;
            Vector2 pushDir = collision.contacts[0].point + transform.position;
            pushDir = pushDir.normalized;

            // rb2D.AddForce(pushDir * pushPower, ForceMode2D.Impulse); 

            Invoke($"{nameof(Despawn)}", 1f);
        }
    }

    void Update() 
    {
        if (notPushing)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        if (transform.position.x < despawn_x)
        {
            Despawn();
        }
    }

    void Despawn()
    {
        // pillarM 위치로 회수
        transform.position = pillarM.transform.position;

        transform.GetChild(0).transform.position = transform.GetChild(0).GetComponent<PillarPart>().SpawnPos;
        transform.GetChild(0).transform.rotation = transform.GetChild(0).GetComponent<PillarPart>().SpawnRotation;
        
        transform.GetChild(1).transform.position = transform.GetChild(1).GetComponent<PillarPart>().SpawnPos;
        
        transform.GetChild(1).transform.rotation = transform.GetChild(1).GetComponent<PillarPart>().SpawnRotation;

        // 비활성화
        gameObject.SetActive(false);
    }

    public void normalToIce()
    {
        pillarIceHigh.SetActive(true);
        pillarIceLow.SetActive(true);
        pillarNormalHigh.SetActive(false);
        pillarNormalLow.SetActive(false);
    }

    public void IceToNormal()
    {
        pillarIceHigh.SetActive(false);
        pillarIceLow.SetActive(false);
        pillarNormalHigh.SetActive(true);
        pillarNormalLow.SetActive(true);
    }

    public void NormalToStreetlamp()
    {
        pillarStreet.SetActive(true);
        pillarNormalHigh.SetActive(false);
        pillarNormalLow.SetActive(false);
    }

    public void StreetlampToNormal()
    {
        pillarStreet.SetActive(false);
        pillarNormalHigh.SetActive(true);
        pillarNormalLow.SetActive(true);
    }
}
