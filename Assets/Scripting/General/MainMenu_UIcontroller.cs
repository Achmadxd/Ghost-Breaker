using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu_UIcontroller : MonoBehaviour
{
    [SerializeField] GameObject transtitionAnim, awakeGameUI;

    #region Transtition Awake Game
    public void AwakeGame() {
        transtitionAnim.SetActive(true);
        StartCoroutine(DelayAwakeGame());
    }

    IEnumerator DelayAwakeGame() {
        yield return new WaitForSeconds(.5f);
        awakeGameUI.SetActive(false);
        yield return new WaitForSeconds(.5f);
        transtitionAnim.SetActive(false);
    }
    #endregion
}
