using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ImagesViewer : MonoBehaviour
{
    public ImagesHolder spriteList;
    public Image imageDisplay;
    public float changeInterval = 3f;

    private int currentIndex = 0;
    private Coroutine changeSpriteCoroutine;

    private void Start()
    {
        if (spriteList != null && spriteList.images.Length > 0 && imageDisplay != null)
        {
            UpdateSprite();
            changeSpriteCoroutine = StartCoroutine(ChangeSpriteRoutine());
        }
        else
        {
            Debug.LogError("SpriteList or ImageDisplay is not assigned or empty.");
        }
    }

    private void UpdateSprite()
    {
        if (spriteList != null && spriteList.images.Length > 0)
        {
            imageDisplay.sprite = spriteList.images[currentIndex];
        }
    }

    private IEnumerator ChangeSpriteRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(changeInterval);
            currentIndex = (currentIndex + 1) % spriteList.images.Length;
            UpdateSprite();
        }
    }

    private void OnDestroy()
    {
        if (changeSpriteCoroutine != null)
        {
            StopCoroutine(changeSpriteCoroutine);
        }
    }
}