using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using TMPro;

public class TutorialUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI keyMoveUpText;
    [SerializeField] private TextMeshProUGUI keyMoveDownText;
    [SerializeField] private TextMeshProUGUI keyMoveLeftText;
    [SerializeField] private TextMeshProUGUI keyMoveRightText;
    [SerializeField] private TextMeshProUGUI keyMoveInteractText;
    [SerializeField] private TextMeshProUGUI keyMoveInteractAltText;
    [SerializeField] private TextMeshProUGUI keyMovePauseText;
    [SerializeField] private TextMeshProUGUI keyMoveGamepadInteractText;
    [SerializeField] private TextMeshProUGUI keyMoveGamepadInteractAltText;
    [SerializeField] private TextMeshProUGUI keyMoveGamepadPauseText;

    private void Start()
    {
        GameInput.instance.OnBindingRebind += GameInput_OnBindingRebind;
        GameManager.Instance.OnStateChanged += GameManager_OnStateChanged;
        
        UpdateVisual();

        Show();
    }

    private void GameManager_OnStateChanged(object sender, System.EventArgs e)
    {
        if(GameManager.Instance.IsCountdownToStartActive())
        {
            Hide();
        }
    }

    private void GameInput_OnBindingRebind(object sender, System.EventArgs e)
    {
        UpdateVisual();
    }

    private void UpdateVisual()
    {
        keyMoveUpText.text = GameInput.instance.GetBindingText(GameInput.Binding.Move_Up);
        keyMoveDownText.text = GameInput.instance.GetBindingText(GameInput.Binding.Move_Down);
        keyMoveLeftText.text = GameInput.instance.GetBindingText(GameInput.Binding.Move_Left);
        keyMoveRightText.text = GameInput.instance.GetBindingText(GameInput.Binding.Move_Right);
        keyMoveInteractText.text = GameInput.instance.GetBindingText(GameInput.Binding.Interact);
        keyMoveInteractAltText.text = GameInput.instance.GetBindingText(GameInput.Binding.InteractAlt);
        keyMovePauseText.text = GameInput.instance.GetBindingText(GameInput.Binding.Pause);
        keyMoveGamepadInteractText.text = GameInput.instance.GetBindingText(GameInput.Binding.Gamepad_Interact);
        keyMoveGamepadInteractAltText.text = GameInput.instance.GetBindingText(GameInput.Binding.Gamepad_InteractAlt);
        keyMoveGamepadPauseText.text = GameInput.instance.GetBindingText(GameInput.Binding.Gamepad_Pause);
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
