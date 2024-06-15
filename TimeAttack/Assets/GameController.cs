using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public TextMeshProUGUI timeLabel;
    public int timecount;
        void Start()
    {
        timeLabel.text = "Time:" + timecount;
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
        
    }
}
