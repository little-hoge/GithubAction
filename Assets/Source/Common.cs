using UnityEngine;

// PC��ʃT�C�Y�ݒ�
public class GameInitial
{
    // WebGL��
#if !UNITY_EDITOR && UNITY_WEBGL

    [RuntimeInitializeOnLoadMethod()]
    static void WebglInit()
    {
     //   Screen.SetResolution(Define.SCREEN_WEBGL_X, Define.SCREEN_WEBGL_Y, false, Define.FPS_WEBGL);
    }
#endif
    // Mac OS X, Windows, Linux��
#if !UNITY_EDITOR && UNITY_STANDALONE

    [RuntimeInitializeOnLoadMethod()]
    static void PCInit()
    {
       // Screen.SetResolution(Define.SCREEN_STANDALONE_X, Define.SCREEN_STANDALONE_Y, false, Define.FPS_STANDALONE);
    }
#endif
}

public static class Define
{

    // 
  //  public const int SCREEN_WEBGL_X = (400), SCREEN_WEBGL_Y = (200), FPS_WEBGL = (30);  // ��ʐݒ� 

    // 
  //  public const int SCREEN_STANDALONE_X = (200), SCREEN_STANDALONE_Y = (400), FPS_STANDALONE = (30);  // ��ʐݒ� 
}