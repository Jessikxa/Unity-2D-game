using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManage : MonoBehaviour
{
    public static gameManage dontDestroy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DestroyNot()
    {
        if (dontDestroy == null)
        {
            dontDestroy = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void levelNext()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void loadingScene(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName);
    }
}
