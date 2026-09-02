using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonHandler : MonoBehaviour
{
    public Button creditsButton;
    public Button quitButton;
    public GameObject creditsPrefab;
    public Button scoreButton;
    public ScoreHolder scoreHolder;
    public TextMeshProUGUI scoreText;
    public GameObject optionsPrefab;
    public Button optionsButton;
    public Button tradeButton;
    public TextMeshProUGUI itemText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        creditsButton.onClick.AddListener(CreditsButtonOnClick);
        quitButton.onClick.AddListener(QuitButtonOnClick);
        scoreButton.onClick.AddListener(ScoreButtonOnClick);
        optionsButton.onClick.AddListener(OptionsButtonOnClick);
        tradeButton.onClick.AddListener(TradeButtonOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreditsButtonOnClick()
    {
        Instantiate(creditsPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }

    void QuitButtonOnClick()
    {
        Invoke(nameof(QuitGame), 0.5f);
    }

    void QuitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    void ScoreButtonOnClick()
    {
        scoreHolder.score++;
        scoreText.SetText("Score: {0}", scoreHolder.score);
    }

    void OptionsButtonOnClick()
    {
        Instantiate(optionsPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }

    void TradeButtonOnClick()
    {
        if (scoreHolder.score >= 2)
        {
            scoreHolder.score -= 2;
            scoreHolder.itemCount++;

            scoreText.SetText("Score: {0}", scoreHolder.score);
            itemText.SetText("Item: {0}", scoreHolder.itemCount);
        }
    }
}
