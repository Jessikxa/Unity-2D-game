using UnityEngine;
using UnityEngine.SceneManagement;

public class destroyingPlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(Collision2D.) {}
        //if player touches enemy {destroy player (ideally also restort)}
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            print("working");
            //Destroy(collision.gameObject);
            //SceneManager.LoadScene(SceneManager.GetActiveScene());
            //SceneManager.LoadScene;
        }
    }
}
