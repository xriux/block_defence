using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {
  public GameObject masterObj;

  void Start() {
  }

  void Update() {
  }

  private void OnCollisionEnter(Collision collision) {
    masterObj.GetComponent<MainMaster>().boxNum--;
    Destroy(gameObject);
  }
}
