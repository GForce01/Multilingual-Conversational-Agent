using UnityEngine;

[CreateAssetMenu(
    fileName = "NewSystemPrompt",
    menuName = "AI/System Prompt Asset",
    order = 1)]
public class SystemPromptAsset : ScriptableObject
{
    [SerializeField, TextArea(8, 20)] private string prompt;

    public string Prompt => prompt;
}
