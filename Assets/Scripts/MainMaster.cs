using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMaster : MonoBehaviour {
  public int boxNum;
  private float nowTime;
  private float emitTime;
  private float emitTime2;
  public GameObject ballObjPrefab;
  public GameObject ballsObj;
  public Text numBlocksText;
  public Text timePassedText;

  void Start() {
    nowTime = 0;
    emitTime = 0;
    emitTime2 = 8;
  }

  void Update() {
    nowTime += Time.deltaTime;

    numBlocksText.text = boxNum.ToString();
    timePassedText.text = nowTime.ToString("F0");
    if (boxNum <= 0) {
      GameOver(nowTime.ToString("F0") + "秒間、持ちこたえた！");
    }

    if (nowTime >= emitTime) {
      emitTime += 5 - nowTime * 0.01f;
      GameObject g = Instantiate(ballObjPrefab, ballsObj.transform);
      g.transform.position = new Vector3(-6.5f, 0.4f, Random.Range(-4f, 4f));
      g.transform.eulerAngles = new Vector3(0, Random.Range(60f, 120f), 0);
      g.GetComponent<StartShot>().speed = 300 + nowTime;
    }

    if (nowTime >= emitTime2) {
      emitTime2 += 5;
      GameObject g = Instantiate(ballObjPrefab, ballsObj.transform);
      g.transform.position = new Vector3(-7f, 0.4f, Random.Range(-2, 2) * 2f);
      g.transform.eulerAngles = new Vector3(0, 90, 0);
      g.GetComponent<StartShot>().speed = 200;
    }
  }

  public void GameOver(string resultMessage) {
    DataSender.resultMessage = resultMessage;
    SceneManager.LoadScene("Result");
  }
}

