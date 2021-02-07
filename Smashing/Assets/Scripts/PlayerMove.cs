using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject player;
    public int Score = 0;
    public GameObject my_timer;
    public GameObject spawn;
    public GameObject respawn;
    public float freezeTime = 1.0f;
    private bool moveAble = true;
    Timer my_timer_script;
    private int Level;

    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Bonus", 0);
        my_timer_script = my_timer.GetComponent<Timer>();
        Score = Score + PlayerPrefs.GetInt("Score");
        Debug.Log(Score);
        Level = SceneManager.GetActiveScene().buildIndex + 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moveAble)
        {
            if (Input.GetAxisRaw("Vertical") > .1)
            {
                rb.AddForce(-speed * Time.deltaTime, 0, 0, ForceMode.Impulse);
            }
            if (Input.GetAxisRaw("Vertical") < -.1)
            {
                rb.AddForce(speed * Time.deltaTime, 0, 0, ForceMode.Impulse);
            }
            if (Input.GetAxisRaw("Horizontal") > .1)
            {
                rb.AddForce(0, 0, speed * Time.deltaTime, ForceMode.Impulse);
            }
            if (Input.GetAxisRaw("Horizontal") < -.1)
            {
                rb.AddForce(0, 0, -speed * Time.deltaTime, ForceMode.Impulse);
            }
        }
  
    }

    public IEnumerator noMove(float time)
    {
        yield return new WaitForSeconds(time);
        moveAble = true;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Red")
        {
            if (PlayerPrefs.GetInt("Lives") > 0)
            {
                PlayerPrefs.SetInt("Lives", PlayerPrefs.GetInt("Lives") - 1);
                player.transform.position = spawn.transform.position;
                moveAble = false;
                Instantiate(respawn);
                StartCoroutine(noMove(freezeTime));
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }
            else
            {
                Destroy(player);
                PlayerPrefs.SetInt("Level", (SceneManager.GetActiveScene().buildIndex));
                SceneManager.LoadScene("GameOver");
            }
        }

        if (col.gameObject.tag == "Blue")
        {

            Destroy(player);
            Score = Score + Mathf.FloorToInt(my_timer_script.TimeLeft) + PlayerPrefs.GetInt("Bonus");
            PlayerPrefs.SetInt("Score", Score);
            PlayerPrefs.SetInt("Levels", PlayerPrefs.GetInt("Levels")+1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

        }
    }


    
}
