using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField]
    string imageRepository = "Background";
    [SerializeField]
    SpriteRenderer sprite;

    List<Texture2D> images;
    int index;

    void Start()
    {
        Utility.Toolbox.Instance.bg = this;
        images = Utility.Toolbox.Instance.Backgrounds.GrabImage(imageRepository);
        index = -1;
        Next();
    }

    public void Next() 
    {
        index++;
        if(index >= images.Count)
            index = 0;
        Sprite s = Sprite.Create(images[index], new Rect(0,0, images[index].width, images[index].height), new Vector2(0.5f,0.5f));
        sprite.sprite = s;
    }
}
