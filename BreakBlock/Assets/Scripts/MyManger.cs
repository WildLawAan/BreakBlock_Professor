using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyManger : MonoBehaviour
{
    public static MyManger instance = null;


    public GameObject Ball;
    public int speed = 1000;

    public int score = 0;

    public Text score_text;

    public GameObject Clear_text;
    public GameObject End_text;

    private bool Ballup = false;


    public static MyManger Instance()
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

    public void block_break()
    {
        score++;
        Debug.Log(score);
        score_text.text = "My Score is" + score;
        if(score == 15)
        {
            Clear_text.SetActive(true);
        }



    }

    public void Game_End()
    {
        End_text.SetActive(true);
    }




}
