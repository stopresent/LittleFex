using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Define
{
    #region Enum

    public enum Scene
    {
        Unknown,
        TitleScene,
        IntroScene,
        LobbyScene,
        LoadingScene,
        //TownScene, 어떤 마을인지 이름이 정해지면 각 마을 마다 씬을 만들어야 됨.
        DungeonScene,
        GameScene,
    }

    public enum Sound
    {
        Bgm,
        SubBgm,
        Effect,
        Max,
    }

    public enum UIEvent
    {
        Click,
        Preseed,
        PointerDown,
        PointerUp,
        BeginDrag,
        Drag,
        EndDrag,
    }

    #endregion
}
