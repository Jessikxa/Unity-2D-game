using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    //public GameObject pointA;
    //public GameObject pointB;
    //private Rigidbody2D rb;
    public Transform[] currentPoint;
    public float speed;
    public int patrolDestination;

    private void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
        //currentPoint = pointB.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (patrolDestination == 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, currentPoint[0].position, speed * Time.deltaTime);
            if (Vector2.Distance(transform.position, currentPoint[0].position) < 0.2f) 
            {
                patrolDestination = 1;
            }
        }

        if (patrolDestination == 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, currentPoint[1].position, speed * Time.deltaTime);
            if (Vector2.Distance(transform.position, currentPoint[1].position) < 0.2f)
            {
                patrolDestination = 0;
            }
        }
    }

    //Vector2 point = currentPoint.position - transform.position;
    //if (currentPoint == pointB.transform)
    //{
    //    rb.linearVelocity = new Vector2(0, speed);
    //}
    //else
    //{
    //    rb.linearVelocity = new Vector2(0, -speed);
    //}

    ////transform.position = Vector2.MoveTowards(transform.position, currentPoint.position, speed);

    //if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointB.transform)
    //{
    //    currentPoint = pointA.transform;
    //}

    //if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointA.transform)
    //{
    //    currentPoint = pointB.transform;
    //}

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag  == "Point A") 
    //    {
    //        currentPoint = pointB.transform;
    //    }

    //    if (collision.gameObject.tag == "Point B")
    //    {
    //        currentPoint = pointA.transform;
    //    }
    //}

}
