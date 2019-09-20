using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pollo : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        print("en el start");
    }

    // Update is called once per frame

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            print("salta");
        }
    }
}