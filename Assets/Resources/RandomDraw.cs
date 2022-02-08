using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RandomDraw : MonoBehaviour
{
    // 활성화,비활성화 할 오브젝트

    //public  GameObject DrawShop; // 뽑기 상점
    //public  GameObject DrawWindow; // 뽑는 창

    // 불러올 이미지 오브젝트
    public  Image DrawImage; // 랜덤 이미지를 출력할 오브젝트
    public  TextMeshProUGUI DrawText; // 랜덤 이미지를 출력할 오브젝트
    
    //숫자 이미지
    public  Sprite Image1;
    public  Sprite Image2;
    public  Sprite Image3;
    public  Sprite Image4;
    public  Sprite Image5;
    public  Sprite Image6;

    // 변수
    public  int RandomInt; // 랜덤 변수



    void Start()
    {
        RandomInt = Random.Range(1, 7); // 랜덤 범위를 설정합니다.
        OneDraw(); 
    }

    public void OneDraw() // 1회 뽑기 버튼을 클릭 시
    {
            //DrawShop.SetActive(false); //뽑기 선택 화면을 비활성화하고,
            //DrawWindow.SetActive(true);// 랜덤 이미지를 출력한 화면을 활성화합니다.
        if (RandomInt == 1) // RandomInt가 1이라면
        {
            DrawImage.sprite = Image1; // DrawImage의 Sprite에 Image1(Sprite)를 적용합니다.
            DrawText.text = "얼룩덜룩 하지 않지 않나? \n자세히 보면 얼룩덜룩하다.";
        }
       else if (RandomInt == 2)
        {
            DrawImage.sprite = Image2;
            DrawText.text = "모든 것과 정말 잘 어울린다. \n미끈하지만 바삭함을 품고 있다.";
        }
        else if (RandomInt == 3)
        {
            DrawImage.sprite = Image3;
            DrawText.text = "보글보글 정도로는 표현할 수 없이 \n부글부글 홀로 끓는 콩이다.";
        }
        else if(RandomInt == 4)
        {
            DrawImage.sprite = Image4;
            DrawText.text = "붉은 도마뱀이 애타게 찾고 있는 등뼈. \n돌려줄 날까지 잘 보관하자.";
        }
        else if(RandomInt == 5)
        {
            DrawImage.sprite = Image5;
            DrawText.text = "변신 고양이는 하루에 아홉 번 변신한다. \n사실 고양이가 아닐지도 모른다.";
        }
        else if(RandomInt == 6)
        {
            DrawImage.sprite = Image6;
            DrawText.text = "민달팽이의 눈물과 콧물을 구별할 수 있는 사람은 없다. \n민달팽이들만 진실을 안다.";
        }
        //Invoke("CloseDraw",2.0f); // 2초 뒤에 CloseDraw 함수를 실행합니다.
    }
}
