using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public static Manager instance = null;


    public GameObject Ball;
    public Text score_bar;
    public int score  = 0;
    public int speed = 1000;

    public GameObject clear_text;
    public GameObject End_text;

    private bool Ballup = false;

    

    public static Manager Instance()
    {
        return instance;
    }

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space) == true && Ballup == false)
        {
            Ballup = true;
            GameStart();

        }
    }

    void GameStart()
    {
        Ball.GetComponent<Rigidbody>().AddForce(Vector3.up * speed);
    }

    public void GameEnd()
    {
        Debug.Log("ENDENDEND");
        End_text.SetActive(true);
        Destroy(Ball);
    }

    public void Break()
    {
        Debug.Log("BreakBall_Scoreup");
        score++;
        score_bar.text = "score_bar" + score;

        if(score == 15)
        {
            clear_text.SetActive(true);
        }
    }



    




}

