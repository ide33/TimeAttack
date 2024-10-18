using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // UIを操作するために必要

public class CountdownTimer : MonoBehaviour
{
    public Text countdownText;  // カウントダウンを表示するUI Text
    public float countdownTime = 3f;  // カウントダウンの時間（3秒）
    private bool countdownStarted = false;
    private float currentTime;

    void Start()
    {
        currentTime = countdownTime;
        countdownText.text = countdownTime.ToString("F0");  // 初期表示（整数値に丸める）
        countdownStarted = true;  // カウントダウンを開始
    }

    void Update()
    {
        if (countdownStarted)
        {
            currentTime -= Time.deltaTime;  // 経過時間を減らす

            if (currentTime > 0)
            {
                countdownText.text = currentTime.ToString("F0");  // テキストを更新（整数表示）
            }
            else
            {
                countdownText.text = "Go!";  // カウントダウンが終わったら「Go!」を表示
                countdownStarted = false;  // カウントダウン終了
                StartGame();  // ゲーム開始
            }
        }
    }

    void StartGame()
    {
        // ゲームを開始するためのロジックをここに記述
        // 例えば、タイマーを開始する、プレイヤーを動かせるようにするなど
        Debug.Log("Game Started!");
    }
}
