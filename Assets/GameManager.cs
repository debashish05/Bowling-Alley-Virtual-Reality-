using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour
{

    public GameObject ball;
    int score = 0;
    GameObject[] pins;
    public Text ScoreUI;
    int turns = 0;
    Vector3[] positions;
    public HighScores highScore;
    public Score scores;
    public Counter counter;

    public GameObject menu;
    //bool flag = true;

    // Start is called before the first frame update
    void Start()
    {
        pins = GameObject.FindGameObjectsWithTag("Pin");
        positions = new Vector3[pins.Length];

        for(int i=0; i<pins.Length; i++)
        {
            positions[i] = pins[i].transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //MoveBall();

        //Debug.Log(turns);
        //ball.transform.position.z > 4.25 ||
        if (ball.transform.position.y < 0.02)
        {
            CountPinsDown();
            ResetPins();
            //ResetPins();

            //counter.counter = counter.counter + 1;
            Debug.Log(counter.counter);
            Debug.Log("turn -> " + turns);

            if (turns == 9)
            {
                if(scores.PlayerScore[9] < score)
                {
                    scores.PlayerScore[9] = score;
                    counter.counter = counter.counter + 1;
                }
                Array.Sort(scores.PlayerScore);
                Array.Reverse(scores.PlayerScore);
            }

            turns++;

        }

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    ResetPins();
        //    turns++;

        //    //counter.counter = counter.counter + 1;
        //    Debug.Log(counter.counter);

        //    if(turns == 10)
        //    {
        //        scores.PlayerScore[counter.counter % 10] = score;
        //        counter.counter = counter.counter + 1;
        //    }

        //    //for (int i = 0; i < scores.PlayerScore.Length; i++)
        //    //{
        //    //    if(scores.PlayerScore[i] == 0)
        //    //    {
        //    //        scores.PlayerScore[i] = score;
        //    //        flag = true;
        //    //        break;
        //    //    }
        //    //    //Debug.Log(scores.PlayerScore[i]);
        //    //}
        //}


        //if(turns == 10 && flag)
        //{
        //    scores.PlayerScore[counter.counter % 10] = score;
        //    counter.counter = counter.counter + 1;
        //    Debug.Log(counter.counter);
        //    flag = false;
        //}

        if (turns >= 10)
        {
            menu.SetActive(true);
            for (int i = 0; i < pins.Length; i++)
            {
                pins[i].SetActive(false);
            }
        }
    }

    //void MoveBall()
    //{
    //    ball.transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime);
    //}

    void CountPinsDown()
    {
        for(int i=0; i<pins.Length; i++)
        {
            if(pins[i].transform.eulerAngles.z > 5 && pins[i].transform.eulerAngles.z < 355 && pins[i].activeSelf)
            {
                score++;
                pins[i].SetActive(false);
            }
        }



        if (score > highScore.highScore)
        {    
            highScore.highScore = score;
        }

        ScoreUI.text = score.ToString();
    }

    void ResetPins()
    {
        Debug.Log("Resetting Pins");
        for(int i=0; i<pins.Length; i++)
        {
            pins[i].SetActive(true);
            pins[i].transform.position = positions[i];
            pins[i].GetComponent<Rigidbody>().velocity = Vector3.zero;
            pins[i].GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            pins[i].transform.rotation = Quaternion.identity;
        }

        ball.transform.position = new Vector3(-0.117f, 0.62815f, -9.939f);
        ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
        ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        ball.transform.rotation = Quaternion.identity;
    }

}
