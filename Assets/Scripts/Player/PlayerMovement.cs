using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 5.5f;
    [SerializeField] private bool _jumping;
    //[SerializeField] private float _move;

    //public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.W))
        //{
        //    Move(new Vector3(0, _speed, 0));
        //    //transform.position += new Vector3(0,_speed,0) * Time.deltaTime;
        //    print("aaa works");
        //}
        if (Input.GetKey(KeyCode.A))
        {
            Move(new Vector3(-_speed, 0, 0));
            //transform.position -= new Vector3(_speed, 0, 0) * Time.deltaTime;
            //print("A key was pressed");
        }
        //if (Input.GetKey(KeyCode.S))
        //{
        //    Move(new Vector3(0, -_speed, 0));
        //    //transform.position -= new Vector3(0, _speed, 0) * Time.deltaTime;
        //    print("S key was pressed");
        //}
        if (Input.GetKey(KeyCode.D))
        {
            Move(new Vector3(_speed, 0, 0));
            //transform.position += new Vector3(_speed, 0, 0) * Time.deltaTime;
            //print("D key was pressed");
        }
        if (Input.GetKey(KeyCode.Space) && _jumping == false)
        {
            Move(new Vector3(0, _speed, 0));
            //transform.position += new Vector3(0,_speed,0) * Time.deltaTime;
            print("aaa works");
        }

    }

        private void Move(Vector3 direction)
    {
        transform.position += direction * Time.deltaTime;
        print("moving");
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            _jumping = false;
        }
    }
}
