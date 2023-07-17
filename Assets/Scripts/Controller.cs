using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
  private float zPos;
  private int mode = 0;
  public GameObject wheels;
  public GameObject cylinders;
  public GameObject wallBehind;
  public GameObject wallFront;

  void Start() {
    zPos = 0;
    mode = 0;
    applyMode(mode);
  }

  void Update() {
    int prevMode = mode;
    if (Input.GetKeyDown(KeyCode.UpArrow)) {
      mode--;
      if (mode < 0) mode = 2;
    }
    if (Input.GetKeyDown(KeyCode.DownArrow)) {
      mode++;
      if (mode > 2) mode = 0;
    }
    if (mode != prevMode) applyMode(mode);

    if (Input.GetKey(KeyCode.LeftArrow)) {
      zPos += Time.deltaTime * 5f;
    } else if (Input.GetKey(KeyCode.RightArrow)) {
      zPos -= Time.deltaTime * 5f;
    }
    if (zPos < -4.5f) zPos = -4.5f;
    if (zPos > 4.5f) zPos = 4.5f;
    transform.position = new Vector3(3f, 0.5f, zPos);
  }

  void applyMode(int mode) {
    if (mode == 0) {
      wallBehind.SetActive(false);
      wallFront.SetActive(true);
      cylinders.SetActive(false);
      wheels.SetActive(false);
    }
    if (mode == 1) {
      wallBehind.SetActive(true);
      wallFront.SetActive(false);
      cylinders.SetActive(true);
      wheels.SetActive(false);
    }
    if (mode == 2) {
      wallBehind.SetActive(true);
      wallFront.SetActive(false);
      cylinders.SetActive(false);
      wheels.SetActive(true);
    }
  }
}
