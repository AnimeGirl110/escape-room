using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneBehavior : MonoBehaviour
{
    private Scene scene;

    private void Start() {
        scene = SceneManager.GetActiveScene();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "PlayerObj") {
            SceneManager.LoadScene(scene.buildIndex + 1, LoadSceneMode.Single);
        }
    }
}
