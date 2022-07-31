using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour
{
    private int[][] floor1 = {
        new int[] {0,0,0,0,0,0,0,0,0,0},
        new int[] {0,0,0,0,0,0,0,0,0,0},
        new int[] {0,0,0,0,0,0,0,0,0,0},
        new int[] {0,0,0,0,0,0,0,0,0,0},
        new int[] {0,0,0,0,0,0,0,0,0,0},
        new int[] {0,0,0,0,0,0,0,0,0,0},
        new int[] {0,0,0,0,0,0,0,0,0,0},
        new int[] {0,0,0,0,0,0,0,0,0,0},
        new int[] {0,0,0,0,0,0,0,0,0,0},
        new int[] {0,0,0,0,0,0,0,0,0,0}
    };
    // private int[][] floor2 = {
        // new int[] {0,0,0,0,0,0,0,0,0,0},
        // new int[] {0,0,0,0,0,0,0,0,0,0},
        // new int[] {0,0,0,0,0,0,0,0,0,0},
        // new int[] {0,0,0,0,0,0,0,0,0,0},
        // new int[] {0,0,0,0,0,0,0,0,0,0},
        // new int[] {0,0,0,0,0,0,0,0,0,0},
        // new int[] {0,0,0,0,0,0,0,0,0,0},
        // new int[] {0,0,0,0,0,0,0,0,0,0},
        // new int[] {0,0,0,0,0,0,0,0,0,0},
        // new int[] {0,0,0,0,0,0,0,0,0,0}
    // };
    // private int[][] floor3 = {
        // new int[] {0,0,0,0,0,0,0,0,0,0},
        // new int[] {0,0,0,0,0,0,0,0,0,0},
        // new int[] {0,0,0,0,0,0,0,0,0,0},
        // new int[] {0,0,0,0,0,0,0,0,0,0},
        // new int[] {0,0,0,0,0,0,0,0,0,0},
        // new int[] {0,0,0,0,0,0,0,0,0,0},
        // new int[] {0,0,0,0,0,0,0,0,0,0},
        // new int[] {0,0,0,0,0,0,0,0,0,0},
        // new int[] {0,0,0,0,0,0,0,0,0,0},
        // new int[] {0,0,0,0,0,0,0,0,0,0}
    // };
    private GameObject[] goals;
    private GameObject[] crates;
    private string goalTag = "Finish";
    private string crateTag = "Crate";
    // private float floor1height = 0.15f;
    // private float floor2height = -4.85f;
    // private float floor3height = -9.85f;
    private float halfFloorSize = 13.5f;
    private int childIndex = 1;
    // Start is called before the first frame update
    void Start()
    {
        goals = GameObject.FindGameObjectsWithTag(goalTag);
        crates = GameObject.FindGameObjectsWithTag(crateTag);
        foreach (GameObject crate in crates) {
            // if (crate.transform.position.y == floor1height) {
                floor1[TranslateToInt(crate.transform.position.x)][TranslateToInt(crate.transform.position.z)] = 1;
            // } else if (crate.transform.position.y == floor2height) {
                // floor2[TranslateToInt(crate.transform.position.x)][TranslateToInt(crate.transform.position.z)] = 1;
            // } else {
                // floor3[TranslateToInt(crate.transform.position.x)][TranslateToInt(crate.transform.position.z)] = 1;
            // }
        }
    }

    // Update is called once per frame
    void Update()
    {
        bool done = true;
        foreach (GameObject goal in goals) {
            GoalScript g = goal.transform.GetChild(childIndex).GetComponent<GoalScript>();
            if (!g.isActivated) {
                done = false;
                break;
            }
        }
        if (done) {
            // INSERT STUFF HERE
            // ********************************************************************************************************************************
            Debug.Log("Done!");
            // ********************************************************************************************************************************
        }
    }

    public void RequestMove(GameObject crate, Vector3 target) {
        // int[][] floor;
        int[][] floor = floor1;
        // if (target.y == floor1height) {
            // floor = floor1;
        // } else if (target.y == floor2height) {
            // floor = floor2;
        // } else {
            // floor = floor3;
        // }
        if (TranslateToInt(target.x) >= 0 && TranslateToInt(target.x) <= 9 && TranslateToInt(target.z) >= 0 && TranslateToInt(target.z) <= 9) {
            if (!(floor[TranslateToInt(target.x)][TranslateToInt(target.z)] == 1)) {
                floor[TranslateToInt(crate.transform.position.x)][TranslateToInt(crate.transform.position.z)] = 0;
                // if (floor[TranslateToInt(target.x)][TranslateToInt(target.z)] == 2) {
                    // if (floor == floor1) {
                        // floor2[TranslateToInt(target.x)][TranslateToInt(target.z)] = 1;
                    // } else {
                        // floor3[TranslateToInt(target.x)][TranslateToInt(target.z)] = 1;
                    // }
                // } else {
                    floor[TranslateToInt(target.x)][TranslateToInt(target.z)] = 1;
                // }
                crate.GetComponent<CrateScript>().Move(target);
            }
        }
    }

    int TranslateToInt(float num) {
        return (int) ((num + halfFloorSize) / 3);
    }
}
