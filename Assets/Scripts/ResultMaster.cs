using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultMaster : MonoBehaviour {
  public Text resultMessageText;

  void Start() {
    resultMessageText.text = DataSender.resultMessage;
  }

  void Update() {
    if (Input.GetKey(KeyCode.Space)) {
      SceneManager.LoadScene("Title");
    }

  }
}
