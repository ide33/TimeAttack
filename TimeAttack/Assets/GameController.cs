using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //  public Text timeLabel;
    // public float timeCount;
    public TextMeshProUGUI timeLabel;
    public int timecount;
        void Start()
    {
        
        timeLabel.text = "Time;" + timecount;
        StartCoroutine(Timer());
    }

    private IEnumerator Timer()
    {
        //処理を繰り返す
        while(true)
        {
            //処理を一定時間だけ中断させる
            yield return new WaitForSeconds(1);
            timecount -=1;
            timeLabel.text = "TIME:" + timecount;
            if(timecount < 1)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }


    void Update()
    {
        // timeCount -= Time.deltaTime;

        // // ToString("0")は小数点を切り捨て
        // // 小数点1位まで表示するにはToString("n1")
        // // 小数点2位まで表示するにはToString("n2")
        // timeLabel.text = "TIME;" + timeCount.ToString("0");

        // if (timeCount < 0)
        // {
        //     SceneManager.LoadScene("GameOver");
        // }
    }
    
}

