using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public List<DocumentContent> docList = new List<DocumentContent>();
    [SerializeField] Animator heartAnim;
    [SerializeField] int a;

    private void Awake()
    {
        instance = this;
    }

    public void AddToList(DocumentContent document) {
        docList.Add(document);
    }

    private void Update()
    {
        SelectHit();
    }

    void SelectHit() {
        switch(a){
            case 1:
                heartAnim.SetBool("Slow", true);
                heartAnim.SetBool("Medium", false);
                heartAnim.SetBool("Fast", false);
                break;
            
            case 2:
                heartAnim.SetBool("Slow", false);
                heartAnim.SetBool("Medium", true);
                heartAnim.SetBool("Fast", false);
                break;

            case 3:
                heartAnim.SetBool("Slow", false);
                heartAnim.SetBool("Medium", false);
                heartAnim.SetBool("Fast", true);
                break;
        }
    }
}
