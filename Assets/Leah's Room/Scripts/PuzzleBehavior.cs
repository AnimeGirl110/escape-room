using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leah {
    public class PuzzleBehavior : MonoBehaviour
    {
        public GameObject tilePrefab;
        private List<GameObject> tiles = new List<GameObject>();
        public int numTilesSide = 6;
        public float tileInterval = 1.05f;
        public float tileOffsetX = 0;
        public float tileOffsetY = 0;

        // Start is called before the first frame update
        void Start()
        {
            for (int col = 0; col < numTilesSide; col++) {
                for (int row = 0; row < numTilesSide; row++) {
                  tiles.Add(Instantiate(
                    tilePrefab, 
                    new Vector3(col * tileInterval + tileOffsetX, 0.3f, row * tileInterval + tileOffsetY), 
                    Quaternion.identity)); 
                }
            }   
            //instantiate a bunch of tiles
        }

        public void TileUpdate() {
            bool allArePressed = true;
            for (int i = 0; i < tiles.Count; i++) {
                    if (!tiles[i].GetComponent<TileBehavior>().GetIsPressed()) {
                        allArePressed = false;
                        //reset all tiles
                    }
            }
        }
    }
}
