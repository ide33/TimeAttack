using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // TextMeshProを使用するための名前空間
using UnityEngine.SceneManagement;  // シーン移行のための名前空間

public class CountdownTimer : MonoBehaviour
{
    public TextMeshProUGUI countdownText;  // TextMeshProのTextオブジェクト
    public float countdownTime = 5f;  // カウントダウンの初期時間（3秒）

    private float currentTime;  // カウントダウンの残り時間

    void Start()
    {
        currentTime = countdownTime;  // カウントダウン時間を初期化
        countdownText.text = countdownTime.ToString("F0");  // 初期表示（小数点なし）
        UpdateCountdownText();  // 初期表示を設定
    }

    void Update()
    {
        currentTime -= Time.deltaTime;  // 毎フレームの経過時間を引いて残り時間を更新

        if (currentTime > 0)
        {
            UpdateCountdownText();  // カウントダウンの残り時間を更新
        }
        else
        {
            countdownText.text = "Go!";  // カウントダウン終了時に「Go!」を表示
            SceneManager.LoadScene("GameScene");  // ゲームシーンに移行
        }
    }

    // カウントダウンのテキストを更新するメソッド
    void UpdateCountdownText()
    {
        countdownText.text = "スタートまで " + currentTime.ToString("F0") + " 秒";  // 「スタートまで」と残り秒数を表示
    }
}
