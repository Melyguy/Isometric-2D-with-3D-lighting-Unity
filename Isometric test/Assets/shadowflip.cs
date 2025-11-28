using UnityEngine;

public class shadowflip : MonoBehaviour
{
    public SpriteRenderer mainSprite;
    public SpriteRenderer shadowSprite; 

    void LateUpdate()
    {
        shadowSprite.sprite = mainSprite.sprite;


        shadowSprite.transform.localPosition = new Vector3(0, -0.3f, 0);
    }
}
