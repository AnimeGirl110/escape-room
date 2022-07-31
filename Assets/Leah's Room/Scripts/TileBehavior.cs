using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leah {
    public class TileBehavior : MonoBehaviour
    {
        private bool hasBeenPressed = false;
        public PuzzleBehavior puzzleBehavior;
        public Material onMat;
        public Material offMat;

        private void Start() {
            puzzleBehavior = GameObject.Find("PuzzleObj").GetComponent<PuzzleBehavior>();
        }

        private void OnCollisionEnter(Collision other) {
            Renderer renderer = GetComponent<Renderer>();    
            if (puzzleBehavior.isPlayingPuzzle) {
                if (other.gameObject.name == "PlayerObj") {
                    if (!hasBeenPressed) {
                        hasBeenPressed = true;
                        renderer.material = onMat;
                        puzzleBehavior.TileUpdate();
                    } else {
                        renderer.material = offMat;
                        puzzleBehavior.ResetAllTiles();
                    }
                }
            }
        }

        public bool GetIsPressed() {
            return hasBeenPressed;
        }

        public void SetIsPressed(bool b) {
            hasBeenPressed = b;
        }
    }
}
