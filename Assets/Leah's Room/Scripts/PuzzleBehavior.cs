using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leah {
    public class PuzzleBehavior : MonoBehaviour
    {
        public GameObject tilePrefab;
        private List<GameObject> tiles = new List<GameObject>();
        public int numTilesSide = 5;
        public float tileInterval = 1;
        public float tileOffsetX = -4.5f;
        public float tileOffsetY = -4.5f;
        public bool isPlayingPuzzle = true;

        // Start is called before the first frame update
        void Start()
        {
            for (int col = 0; col < numTilesSide; col++) {
                for (int row = 0; row < numTilesSide; row++) {
                  tiles.Add(Instantiate(
                    tilePrefab, 
                    new Vector3(col * tileInterval + tileOffsetX, 0.2f, row * tileInterval + tileOffsetY), 
                    Quaternion.identity)); 
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
            GameObject.Find("Door_Joint").GetComponent<Animator>().Play("DoorOpening", 0, 0);
            //open door
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
