using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Red : PlayerPiece {
    public void OnMouseDown() {
        if (!ReadyToMove) {
            MakePlayerReadyToMove(PathParent.RedPathPoint);
            return;
        }
        MovePlayer(PathParent.RedPathPoint);
    }
}
