using UnityEngine;
using UnityEngine.SceneManagement;

public class finishPoint : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //laad volgende level
            SceneManager.LoadScene(1);
            //gameManage.dontDestroy.levelNext();
        }
        //SceneManager.LoadScene(1);

    }

}
