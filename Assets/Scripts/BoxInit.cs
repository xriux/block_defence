using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxInit : MonoBehaviour {
  public GameObject boxObjPrefab;
  public GameObject boxesObj;

  void Awake() {
    int boxNum = 0;
    GameObject masterObj = GameObject.Find("Master");
    for (int x = 0; x < 5; x++) {
      for (int y = 0; y < 2; y++) {
        GameObject g = Instantiate(boxObjPrefab, boxesObj.transform);
        g.transform.position = new Vector3((5f + (1f * y)), 0.4f, (-4f + (2f * x)));
        g.GetComponent<Destroyer>().masterObj = masterObj;
        boxNum++;
      }
    }
    masterObj.GetComponent<MainMaster>().boxNum = boxNum;
  }

  void Start() {

  }

  void Update() {

  }
}
