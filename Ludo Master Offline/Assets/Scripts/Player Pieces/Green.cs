using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green : PlayerPiece {
    public void OnMouseDown() {
        if (!ReadyToMove) {
            MakePlayerReadyToMove(PathParent.GreenPathPoint);
            return;
        }
        MovePlayer(PathParent.GreenPathPoint);
    }
}
