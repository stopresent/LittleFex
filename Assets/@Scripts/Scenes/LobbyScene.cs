using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using static Define;

public class LobbyScene : BaseScene
{
    protected override void Init()
    {
        base.Init();

        SceneType = Define.Scene.LobbyScene;

        Managers.UI.ShowSceneUI<UI_LobbyScene>();


        //LobbyUI

    }

    public override void Clear()
    {

    }

}
