using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(CanvasGroup))]
public class SettingScreen : MonoBehaviour
{
    private CanvasGroup _settingsScreenCG;

    private void Start()
    {
        _settingsScreenCG = GetComponent<CanvasGroup>();
    }

    public void CloseScreen()
    {
        _settingsScreenCG.DOFade(0, 1).OnComplete(() =>
        {
            gameObject.SetActive(false);
        });
    }
}
