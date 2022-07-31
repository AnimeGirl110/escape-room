using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leah {
    public class PuzzleBehavior : MonoBehaviour
    {
        public GameObject tilePrefab;
        public GameObject barrierPrefab;
        private List<GameObject> tiles = new List<GameObject>();
        public float tileInterval = 1.005f;
        public float tileOffsetX = -2.75f;
        public float tileOffsetY = -4.25f;
        public bool isPlayingPuzzle = true;

        private int[][] grid = new int[][] {
            new int[] {1, 1, 1, 0, 1, 1, 1, 1, 1},
            new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0},
            new int[] {0, 0, 0, 0, 0, 1, 0, 0, 0},
            new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0},
            new int[] {0, 1, 0, 0, 0, 0, 0, 0, 0},
            new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0},
            new int[] {0, 0, 0, 0, 1, 0, 0, 0, 0},
        };

        // Start is called before the first frame update
        void Start()
        {
            for (int col = 0; col < grid.Length; col++) {
                for (int row = 0; row < grid[0].Length; row++) {
                    if (grid[col][row] == 0) {
                        tiles.Add(Instantiate(
                            tilePrefab, 
                            new Vector3(col * tileInterval + tileOffsetX, 0.3f, row * tileInterval + tileOffsetY), 
                            Quaternion.identity)); 
                    } else {
                        Instantiate(
                            barrierPrefab, 
                            new Vector3(col * tileInterval + tileOffsetX, 0.3f, row * tileInterval + tileOffsetY), 
                            Quaternion.identity); 
                    }
                }
            }
            ResetAllTiles();
        }

        public void TileUpdate() {
            for (int i = 0; i < tiles.Count; i++) {
                if (!tiles[i].GetComponent<TileBehavior>().GetIsPressed()) { //checks all tiles
                    return;
                }
            } 
            isPlayingPuzzle = false;
            GameObject.Find("Door_Joint").GetComponent<Animation>().Play("DoorOpening");
            GameObject.Find("Door_Joint").GetComponent<AudioSource>().Play();
            
        }

        public void ResetAllTiles() {
            for (int i = 0; i < tiles.Count; i++) {
                GameObject tile = tiles[i];
                tile.GetComponent<TileBehavior>().SetIsPressed(false);
                tile.GetComponent<Renderer>().material = tile.GetComponent<TileBehavior>().offMat;
            }
        }
    }
}
