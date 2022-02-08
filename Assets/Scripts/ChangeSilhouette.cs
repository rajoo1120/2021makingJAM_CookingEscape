using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSilhouette : MonoBehaviour
{
    public Sprite[] ItemImage;
    public GameObject GameObject_item;
    int i = 0;


    private void Start()
    {
        GameObject_item.SetActive(false);
        first();
    }

    public void first()
    {
        GameObject_item.GetComponent<Image>().sprite = ItemImage[i];
        GameObject_item.SetActive(true);
        Invoke("second", 0.7f);
    }

    public void second()
    {
        i++;
        GameObject_item.GetComponent<Image>().sprite = ItemImage[i];
        GameObject_item.SetActive(true);
        Invoke("third", 0.7f);
    }

    public void third()
    {
        i++;
        GameObject_item.GetComponent<Image>().sprite = ItemImage[i];
        GameObject_item.SetActive(true);
        Invoke("four", 0.7f);
    }

    public void four()
    {
        i++;
        GameObject_item.GetComponent<Image>().sprite = ItemImage[i];
        GameObject_item.SetActive(true);
        Invoke("fifth", 0.7f);
    }

    public void fifth()
    {
        i++;
        GameObject_item.GetComponent<Image>().sprite = ItemImage[i];
        GameObject_item.SetActive(true);
        Invoke("six", 0.7f);
    }

    public void six()
    {
        i++;
        GameObject_item.GetComponent<Image>().sprite = ItemImage[i];
        GameObject_item.SetActive(true);
    }
}
