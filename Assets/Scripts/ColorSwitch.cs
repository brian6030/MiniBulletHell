using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSwitch : MonoBehaviour
{
    [SerializeField] GameObject aircraft;   
    [SerializeField] Texture orange;
    [SerializeField] Texture blue;
    [SerializeField] Button button;

    bool isBlue = false;

    MeshRenderer meshRenderer;
    Sprite orangeSprite;
    Sprite blueSprite;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = aircraft.GetComponent<MeshRenderer>();
        meshRenderer.material.mainTexture = orange;

        orangeSprite = button.GetComponent<Button>().image.sprite;
        blueSprite = button.GetComponent<SpriteRenderer>().sprite;
    }

    public void Switch()
    {
        if (isBlue)
        {
            meshRenderer.material.mainTexture = orange;
            isBlue = false;

            button.image.sprite = orangeSprite;
        }
        else
        {
            meshRenderer.material.mainTexture = blue ;
            isBlue = true;

            button.image.sprite = blueSprite;
        }
            
    }
}
