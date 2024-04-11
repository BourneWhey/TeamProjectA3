using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneLoad : MonoBehaviour
{
    public int xieIndex;
    public int panIndex;
    public int weiIndex;
    public int zhaoIndex;
    public void LoadSceneXie()
    {
        SceneManager.LoadScene(xieIndex);
    }
    public void LoadScenePan()
    {
        SceneManager.LoadScene(panIndex);
    }
    public void LoadSceneWei()
    {
        SceneManager.LoadScene(weiIndex);
    }
    public void LoadSceneZhao()
    {
        SceneManager.LoadScene(zhaoIndex);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
