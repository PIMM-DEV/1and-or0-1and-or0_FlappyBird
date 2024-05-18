using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    SkillCat skillCat;
    SkillNyan skillNyan;
    public bool isGameOver;
    [SerializeField] GameObject gameOverImage;
    void Start()
    {
        isGameOver = false;
        skillCat = transform.parent.gameObject.GetComponent<SkillCat>();
        skillNyan = transform.parent.gameObject.GetComponent<SkillNyan>();
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        print("뭐야");
        print(LayerMask.LayerToName(other.gameObject.layer));
        if (!skillCat.skillOn && !skillNyan.skillOn && LayerMask.LayerToName(other.gameObject.layer) == "Obstacle")
        {
            GameOver();
        }    
    }

    public void GameOver()
    {
        print("GameOver임");
        isGameOver = true;
        gameOverImage.SetActive(true);
    }
}
