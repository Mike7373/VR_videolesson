using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoPoint : MonoBehaviour
{
    private Button _button;
    [SerializeField] private List<Sprite> _sprites;
    // Start is called before the first frame update
    private void Awake()
    {
        UI_Manager.Instance.infoPoint = this;
    }
    void Start()
    {
        _button= GetComponent<Button>();
        _button.image.sprite = _sprites[0];
    }

    private void OnMouseEnter()
    {
        _button.image.sprite = _sprites[1];
    }

    private void OnMouseExit()
    {
        _button.image.sprite = _sprites[0];
    }

    private void OnMouseDown()
    {
        OpenInfoPanel();
    }
    public void OpenInfoPanel()
    {
        UI_Manager.Instance.infoPanel.gameObject.SetActive(true);
    }
   
}
