using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public Animator anim;
    public AudioSource AudioSource;
    public AudioClip pickAudio;
    public CanvasController canvasController;

    private void Start()
    {
        canvasController = FindObjectOfType<CanvasController>();    
        anim = GetComponent<Animator>();
    }

    public void OpenOrClose(bool flag)
    {
        anim.SetBool("bounce", flag);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        OpenOrClose(true);
        AudioSource.PlayOneShot(pickAudio);
        Destroy(gameObject, 2f);
        //GameManager.instance.TreaCount++;
        canvasController.count--;
        //TODO 加速 记录捡取数量 

    }
}
