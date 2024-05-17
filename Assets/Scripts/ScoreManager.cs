using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public float Score;
    public float timer;
    [SerializeField] TextMeshProUGUI textMeshProUGUI;

    void Awake()
    {
        Score = 0;
    }

    void Update()
    {
        SetTimerAndScore();

        UpdateScoreTMP();
    }

    void SetTimerAndScore()
    {
        timer += Time.deltaTime;
        Score = Mathf.Floor(timer * 10f) * 10 / 2;
    }

    void UpdateScoreTMP()
    {
        textMeshProUGUI.text = $"Score: {Score}";
    }
}
