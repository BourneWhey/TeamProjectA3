using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        instance = this;
    }

    public Text treasureCount;
    public void LoadScene()
    {
        SceneManager.LoadScene(0);
    }

    public int TreaCount;

    private void Update()
    {
        treasureCount.text = "Score:" + TreaCount.ToString();
    }



}
