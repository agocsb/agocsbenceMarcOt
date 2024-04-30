using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    [SerializeField] Button restart;
    [SerializeField] string gameSceneName;

    public void restartGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
