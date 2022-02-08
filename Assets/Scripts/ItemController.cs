using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ItemController : MonoBehaviour
{
    GameObject player;

    public static List<int> types = new List<int>();
    public Sprite[] ItemImage;
    public GameObject GameObject_item0, GameObject_item1, GameObject_item2;

    SlotArray itemslot;

    void Start()
    {
        types = new List<int>();
        player = GameObject.Find("Player");

        itemslot = new SlotArray();
        itemslot.slot_init();

        GameObject_item0.SetActive(false);
        GameObject_item1.SetActive(false);
        GameObject_item2.SetActive(false);

    }

    public void _get_new_item_on_the_road(string name)
    {
        int type = CheckItem(name);

        //꽝받으면 바로 넘어감

        /*if (itemslot.full())
        {
            //full 확인 해서 씬 넘기기 
            return;
        }*/

        /*if(type == 0)
        {
            LoadingSceneManager.LoadScene("badEnding");
            //엔딩씬 넘기기
            return;
        }*/

        if (CheckItemDuplicate(type))
        {
            //Debug.Log("duplicate");
            return;
        }

        else if (itemslot.empty())
        {
            itemslot.num.Add(name);
            types.Add(type);
            // item0 <- new item
            GameObject_item0.GetComponent<Image>().sprite = ItemImage[type];
            GameObject_item0.SetActive(true);
            return;
        }
        else if (itemslot.item_have() == 1)
        {
            itemslot.num.Add(name);
            types.Add(type);
            // item1 <- new item
            GameObject_item1.GetComponent<Image>().sprite = ItemImage[type];
            GameObject_item1.SetActive(true);
        }
        else
        {
            itemslot.num.Add(name);
            types.Add(type);
            // item2 <- new item
            GameObject_item2.GetComponent<Image>().sprite = ItemImage[type];
            GameObject_item2.SetActive(true);


            SelectEnding();
        }

    }

    public void SelectEnding()
    {
        if (types.Contains(0))
        {
            LoadingSceneManager.LoadScene("badEnding");
        }

        else if (types.Contains(1) && !types.Contains(0))
        {
            LoadingSceneManager.LoadScene("rareEnding");
        }

        else if(types.Contains(2)&& types.Contains(3))
        {
            if (types.Contains(4))
                LoadingSceneManager.LoadScene("kkochiEnding");
            else
                LoadingSceneManager.LoadScene("cocktailEnding");
        }

        else if (types.Contains(4) && types.Contains(5))
        {
            if (types.Contains(2))
                LoadingSceneManager.LoadScene("tangEnding");
            else
                LoadingSceneManager.LoadScene("fermentedEnding");
        }

    }
    
    public bool CheckItemDuplicate(int type)
    {
        for(int i = 0; i < types.Count; i++)
        {
            if (types[i]==type)
                return true;
        }
        return false;
    }
    public int CheckItem(string name)
    {

        int itemType=0;

        if (name == "grass" || name =="grass(Clone)")
        {
            itemType = 0;
        }
        else if (name == "oil" || name == "oil(Clone)")
        {
            itemType = 1;
        }
        else if (name == "bone" || name == "bone(Clone)")
        {
            itemType = 2;
        }
        else if (name == "cat" || name == "cat(Clone)")
        {
            itemType = 3;
        }
        else if (name == "kong" || name == "kong(Clone)")
        {
            itemType = 4;
        }
        else if (name == "teers" || name == "teers(Clone)")
        {
            itemType = 5;
        }
        return itemType;
    }


public class SlotArray
{
    public List<string> num;
    public void slot_init()
    {
        num = new List<string>();
    }

    public int item_have()
    {
        return num.Count;
    }

    public bool empty()
    {
        return (num.Count == 0);
    }

    public bool full()
    {
        return (num.Count == 3);
    }
}
}
