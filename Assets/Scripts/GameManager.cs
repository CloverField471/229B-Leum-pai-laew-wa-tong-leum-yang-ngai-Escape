using TMPro; 
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private int score = 0;
    public int targetScore = 10;
    public string creditsSceneName = "CreditsScene";
    public TextMeshProUGUI scoreText;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void AddScore(int value)
    {
        score += value;
        UpdateUI();

        if (score >= targetScore)
        {
            LoadCreditsScene();
        }

    }
    
    void LoadCreditsScene()
    {
        SceneManager.LoadScene(creditsSceneName);
    }

    void UpdateUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}
