using UnityEngine;

public class PlayrHorizontalPotision : MonoBehaviour
{
    void Awake()
    {
        SetPlayerSpawnPosition();
    }

    void SetPlayerSpawnPosition()
    {
        Vector3 spawnPos = Camera.main.ScreenToWorldPoint(new Vector3(150, Camera.main.pixelHeight/2, 10));
        transform.position = spawnPos;
    }

    void Update()
    {
        // print($"{Camera.main.WorldToScreenPoint(transform.position)}");
        
        // print($"{Camera.main.ScreenToWorldPoint(Camera.main.WorldToScreenPoint(transform.position))}");
        
    }
}
