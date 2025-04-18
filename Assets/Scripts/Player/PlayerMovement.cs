using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 5.5f;
    [SerializeField] private bool _jumping = false;
    Rigidbody2D rb;
    //[SerializeField] private float _move;
    Animator animator;

    //public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
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
            //_jumping = false;
            animator.SetBool("isJumping", !_jumping);
        }

    }

        private void Move(Vector3 direction)
    {
            transform.position += direction * Time.deltaTime;
        
        animator.SetFloat("xVelocity", Mathf.Abs(rb.linearVelocity.x));
        animator.SetFloat("yVelocity", (rb.linearVelocity.y));
        print("moving");
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            _jumping = true;
            animator.SetBool("isJumping", !_jumping);
        }
    }
}
