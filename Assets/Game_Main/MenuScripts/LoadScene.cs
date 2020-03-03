using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public Text loadingText;
  //  public Image progressBar;
    private int curProgressValue = 0;

    void FixedUpdate()
    {
        int progressValue = 100;

        if (curProgressValue < progressValue)
        {
            curProgressValue++;
        }

        loadingText.text = "正在努力加载..." + curProgressValue + "%";//实时更新进度百分比的文本显示  

       // progressBar.fillAmount = curProgressValue / 100f;//实时更新滑动进度图片的fillAmount值  

        if (curProgressValue == 100)
        {
            loadingText.text = "OK";//文本显示完成OK
            SceneManager.LoadScene("Game_Main");
        }
    }
}