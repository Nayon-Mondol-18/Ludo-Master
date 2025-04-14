using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yellow : PlayerPiece {
    public void OnMouseDown() {
        if (!ReadyToMove) {
            MakePlayerReadyToMove(PathParent.YellowPathPoint);
            return;
        }
        MovePlayer(PathParent.YellowPathPoint);
    }
}
