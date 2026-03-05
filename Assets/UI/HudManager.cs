using UnityEngine;
using UnityEngine.UIElements;

public class HudManager : MonoBehaviour
{

    UIDocument hud;

    VisualElement root;
    Image PlayerIcon;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hud = GetComponent<UIDocument>();
        root = hud.rootVisualElement;

        PlayerIcon = root.Q<Image>("PlayerIcon");
        PlayerIcon.tintColor = Color.red;

        PlayerIcon.RegisterCallback<ClickEvent>(OnClicked);
    }


    void OnClicked(ClickEvent e)
    {
       
        e.StopPropagation();
    }
    private void OnEnable()
    {
        
    }
    private void OnDisable()
    {
        PlayerIcon.UnregisterCallback<ClickEvent>(OnClicked);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
