using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leah {
    public class PuzzleBehavior : MonoBehaviour
    {
        public GameObject tilePrefab;
        private List<GameObject> tiles = new List<GameObject>();

        // Start is called before the first frame update
        void Start()
        {
            tiles.Add(Instantiate(tilePrefab, new Vector3(2.1f, 0.6f, 0), Quaternion.identity));    
            //instantiate a bunch of tiles
        }

        public void TileUpdate() {
            bool allArePressed = true;
            for (int i = 0; 9 < tiles.Count; i++) {
                    if (!tiles[i].GetComponent<TileBehavior>().GetIsPressed()) {
                        allArePressed = false;
                        //reset all tiles
                    }
            }
        }
    }
}
