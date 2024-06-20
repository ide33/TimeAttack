using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Unity.MaleDummy;

public class Goal : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
        void OnTriggerEnter(Collider col)
        {
            if(col.tag == "Player")
            {
                //ゲームマネージャーにゴールしたことを知らせる
                gameManager.Goal();
                //キャラクターの動作を止める
                col.GetComponent<MaleDummy>().enabled = false;
                col.GetComponent<MaleDummy>().enabled = false;
                col.GetComponent<Rigidbody>().velocity = Vector3.zero;
                col.GetComponent<Animator>().SetFloat("Forward", 0f);
            }
        }
}
