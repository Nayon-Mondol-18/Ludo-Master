using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue : PlayerPiece {
    public void OnMouseDown() {
        if (!ReadyToMove) {
            MakePlayerReadyToMove(PathParent.BluePathPoint);
            return;
        }
        MovePlayer(PathParent.BluePathPoint);
    }
}
