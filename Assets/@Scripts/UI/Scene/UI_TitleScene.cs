using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_TitleScene : UI_Scene
{
    #region Enum

    public enum Images
    { 
        TitleBG,
    }

    public enum Buttons
    {
        StartBtn,
        ContinueBtn,
        SelectLanguageBtn,
    }

    #endregion

    public override bool Init()
    {
        if (base.Init() == false)
            return false;
        
        BindImage(typeof(Images));
        BindButton(typeof(Buttons));

        GetButton((int)Buttons.StartBtn).gameObject.BindEvent(() =>
        {
            // TODO 사운드 추가

            Managers.Scene.LoadScene(Define.Scene.LobbyScene, transform);
        });

        return true;
    }
}
