using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartShot : MonoBehaviour {
  private float lifeTime;
  public float speed;

  void Start() {
    lifeTime = 10;
    gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * speed);
  }

  void Update() {
    lifeTime -= Time.deltaTime;
    if (lifeTime <= 0) {
      Destroy(gameObject);
    }
  }
}
