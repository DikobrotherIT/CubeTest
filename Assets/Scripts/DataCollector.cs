using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class DataCollector : MonoBehaviour
{
    [SerializeField] private TMP_InputField _speedInput;
    [SerializeField] private TMP_InputField _distanceInput;
    [SerializeField] private TMP_InputField _spawnTimeInput;

    public void SaveAllData()
    {
        float speed;
        float distance;
        float spawnTime;

        float.TryParse(_speedInput.text, out speed);
        float.TryParse(_distanceInput.text, out distance);
        float.TryParse(_spawnTimeInput.text, out spawnTime);

        PlayerPrefs.SetFloat("Speed", speed);
        PlayerPrefs.SetFloat("Distance", distance);
        PlayerPrefs.SetFloat("SpawnTime", spawnTime);
    }
}
