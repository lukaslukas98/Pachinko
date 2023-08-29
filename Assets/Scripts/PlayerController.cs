using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    [SerializeField] private float spawnRate = 0.5f;
    [SerializeField] private float spawnDelay = 5f;
    [SerializeField] private float horizontalInput;
    [SerializeField] private float speed = 20f;


    [SerializeField] public float zRange = 21.0f;

    [SerializeField] private int ballsRemaining = 50;
    [SerializeField] private Text ballsRemainingText;




    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnBall",spawnDelay,spawnRate);
        ballsRemainingText.text = "Balls: " + ballsRemaining;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        transform.Translate(new Vector3(0, 0, horizontalInput));

        if (transform.position.z <= -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        if (transform.position.z >= zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }


        if (Input.GetKeyDown(KeyCode.Space) && ballsRemaining>0)
        {
            ballsRemaining--;
            ballsRemainingText.text = "Balls: " + ballsRemaining;
            Instantiate(ball,new Vector3(0,24f,transform.position.z),ball.transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

    void SpawnBall()
    {

        Instantiate(ball, new Vector3(0, 24f, transform.position.z), ball.transform.rotation);
    }
}
