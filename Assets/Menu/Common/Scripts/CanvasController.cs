using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    public List<GameObject> treasures = new List<GameObject>();
    public int count;
    public Text sceneName;
    public Text overText;
    public Text tCount;
    public AudioSource audioSource;
    public Slider volume;
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void Start()
    {
         count = treasures.Count;
         sceneName.text = SceneManager.GetActiveScene().name;
    }

    private void Update()
    {
        tCount.text = count.ToString();
        if(count<= 0)
        {
            count++;
            StartCoroutine(DelayLoad());
        }
        audioSource.volume = volume.value;
    }

    IEnumerator DelayLoad()
    {
        overText.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }
}
