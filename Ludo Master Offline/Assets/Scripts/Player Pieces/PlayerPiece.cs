using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPiece : MonoBehaviour
{
    public bool ReadyToMove = false;
    public int StepsToMove, StepsAlreadyMoved;
    public PathObjectParent PathParent;
    private void Awake() {
        PathParent = FindObjectOfType<PathObjectParent>();
    }
    public void MakePlayerReadyToMove(PathPoint[] path) {
        ReadyToMove = true;
        transform.position = path[0].transform.position;
        StepsAlreadyMoved = 1;
    }
    public void MovePlayer(PathPoint[] path) {
        StartCoroutine(MovePlayerEnum(path));
    }
    IEnumerator MovePlayerEnum(PathPoint[] path) {
        StepsToMove = UnityEngine.Random.Range(1, 7);
        for (int i = StepsAlreadyMoved; i < (StepsAlreadyMoved + StepsToMove); ++i) {
            transform.position = path[i].transform.position;
            yield return new WaitForSeconds(0.4f);
        }
        StepsAlreadyMoved += StepsToMove;
    }
}
