using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckManager : MonoBehaviour
{
    public Sprite[] ItemImage;
    public GameObject GameObject_item, GameObject_item0, GameObject_item1, GameObject_item2, center;
    public GameObject t1, t2, t3, t4, t5, line;

    private void Start()
    {
        GameObject_item.SetActive(false);
        GameObject_item0.SetActive(false);
        GameObject_item1.SetActive(false);
        GameObject_item2.SetActive(false);
        center.SetActive(false);
        t1.SetActive(false);
        t2.SetActive(false);
        t3.SetActive(false);
        t4.SetActive(false);
        t5.SetActive(false);
        line.SetActive(false);


        if (ItemController.types.Contains(0))
        {
            GameObject_item.GetComponent<Image>().sprite = ItemImage[0];
            GameObject_item.SetActive(true);
            center.GetComponent<Image>().sprite = ItemImage[6];
            center.SetActive(true);
            t4.GetComponent<Text>().text = "알록달록 풀꽃";
            t4.SetActive(true);
            line.SetActive(true);
            t5.GetComponent<Text>().text = "향이 너무 강해서 다른 재료는 소용없어!";
            t5.SetActive(true);
        }
        else if (ItemController.types.Contains(1) && !ItemController.types.Contains(0))
        {
            GameObject_item.GetComponent<Image>().sprite = ItemImage[1];
            GameObject_item.SetActive(true);
            center.GetComponent<Image>().sprite = ItemImage[7];
            center.SetActive(true);
            t4.GetComponent<Text>().text = "해바라기 씨유";
            t4.SetActive(true);
            line.SetActive(true);
            t5.GetComponent<Text>().text = "무엇과 함께하든 바삭해 질 뿐";
            t5.SetActive(true);
        }
        else if (ItemController.types.Contains(2) && ItemController.types.Contains(3))
        {
            if (ItemController.types.Contains(4))
            {
                GameObject_item0.GetComponent<Image>().sprite = ItemImage[2];
                GameObject_item0.SetActive(true);
                t1.GetComponent<Text>().text = "붉은 도마뱀의 등뼈";
                t1.SetActive(true);
                GameObject_item1.GetComponent<Image>().sprite = ItemImage[3];
                GameObject_item1.SetActive(true);
                t2.GetComponent<Text>().text = "변신 고양이의 수염";
                t2.SetActive(true);
                GameObject_item2.GetComponent<Image>().sprite = ItemImage[4];
                GameObject_item2.SetActive(true);
                t3.GetComponent<Text>().text = "부글부글 콩";
                t3.SetActive(true);
            }
            else
            {
                GameObject_item0.GetComponent<Image>().sprite = ItemImage[2];
                GameObject_item0.SetActive(true);
                t1.GetComponent<Text>().text = "붉은 도마뱀의 등뼈";
                t1.SetActive(true);
                GameObject_item1.GetComponent<Image>().sprite = ItemImage[3];
                GameObject_item1.SetActive(true);
                t2.GetComponent<Text>().text = "변신 고양이의 수염";
                t2.SetActive(true);
                GameObject_item2.GetComponent<Image>().sprite = ItemImage[5];
                GameObject_item2.SetActive(true);
                t3.GetComponent<Text>().text = "민달팽이의 눈물";
                t3.SetActive(true);
            }
        }
        else if (ItemController.types.Contains(4) && ItemController.types.Contains(5))
        {
            if (ItemController.types.Contains(2))
            {
                GameObject_item0.GetComponent<Image>().sprite = ItemImage[2];
                GameObject_item0.SetActive(true);
                t1.GetComponent<Text>().text = "붉은 도마뱀의 등뼈";
                t1.SetActive(true);
                GameObject_item1.GetComponent<Image>().sprite = ItemImage[4];
                GameObject_item1.SetActive(true);
                t2.GetComponent<Text>().text = "부글부글 콩";
                t2.SetActive(true);
                GameObject_item2.GetComponent<Image>().sprite = ItemImage[5];
                GameObject_item2.SetActive(true);
                t3.GetComponent<Text>().text = "민달팽이의 눈물";
                t3.SetActive(true);
            }
            else
            {
                GameObject_item0.GetComponent<Image>().sprite = ItemImage[3];
                GameObject_item0.SetActive(true);
                t1.GetComponent<Text>().text = "변신 고양이의 수염";
                t1.SetActive(true);
                GameObject_item1.GetComponent<Image>().sprite = ItemImage[4];
                GameObject_item1.SetActive(true);
                t2.GetComponent<Text>().text = "부글부글 콩";
                t2.SetActive(true);
                GameObject_item2.GetComponent<Image>().sprite = ItemImage[5];
                GameObject_item2.SetActive(true);
                t3.GetComponent<Text>().text = "민달팽이의 눈물";
                t3.SetActive(true);
            }
        }
    }
}

