using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using UnityEngine;

public class ExitBotton : MonoBehaviour {

    public Texture btnTexture;
    //public Texture atnTexture;
    void OnGUI()
    {
       
       // if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 130, 70, 70), atnTexture))
       // {
       //     Debug.LogError("Please assign a texture on the inspector");
       // }
        if (GUI.Button(new Rect(UnityEngine.Screen.width-60 , 10 , 50, 50), btnTexture))
        {
            //MessageBox.Show("游戏结束");
            // UnityEditor.EditorApplication.isPlaying = false;
            UnityEngine.Application.Quit();
        }
    }

}
