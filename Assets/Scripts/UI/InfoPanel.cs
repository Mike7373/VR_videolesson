using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPanel : MonoBehaviour
{
    private void Awake()
    {
        UI_Manager.Instance.infoPanel= this;
    }
    void Start()
    {
        Debug.Log("Start info panel");
        gameObject.SetActive(false);
    }
}
