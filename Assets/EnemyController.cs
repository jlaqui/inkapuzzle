using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 0f;
    public float flag = 0f;
    private Rigidbody2D rg;
    private Animator animator;
    public GameObject obj;

    public GameObject[] waypoints;
    int currentWP = 0;

    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        flag = 2f;
        animator.SetFloat("Speed", flag);

        if (Vector3.Distance(this.transform.position, waypoints[currentWP].transform.position) < 1)
        {
            currentWP++;
            transform.Rotate(new Vector3(0f, 180f, 0f));
        }
            
        if (currentWP >= waypoints.Length)
            currentWP = 0;
            
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWP].transform.position, speed * Time.deltaTime);

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Player"))
        {
            obj.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
