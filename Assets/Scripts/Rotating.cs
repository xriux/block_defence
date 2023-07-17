using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating : MonoBehaviour {
  public float angle;
  void Start() {
  }

  void Update() {
    transform.Rotate(0, Time.deltaTime * angle, 0);
  }
}
