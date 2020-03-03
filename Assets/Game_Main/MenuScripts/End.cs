using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    //public Data data;

    public Text weedingText;
    public Text loadingText;
    private float curProgressValue = 0f;
    private float progressValue = 0f;
   
    void FixedUpdate()
    {
        if (Data.isfinish == false)
        {
            progressValue = 150f;
            weedingText.text = "未完成";
        }
        else
        {
            progressValue = 150+500-Data.timer;
            weedingText.text = "恭喜完成赛道";
        }
        

        if (curProgressValue < progressValue)
        {
            curProgressValue++;
        }

        loadingText.text = "您最后得分为" + curProgressValue + "分";
        //loadingText.text =  curProgressValue + "分";

        
    }
    private void OnGUI()
    {
        
            if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 130, 70, 70), "重新开始"))
            {
                SceneManager.LoadScene("Game_Main");
            }
            if (GUI.Button(new Rect(Screen.width / 2 + 50, Screen.height / 2 + 130, 70, 70), "退出游戏"))
            {
                UnityEngine.Application.Quit();
            }
        
    }
}
