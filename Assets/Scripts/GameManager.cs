using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject black;

    [SerializeField]
    private GameObject red;

    [SerializeField]
    private GameObject white1;

    [SerializeField]
    private GameObject white2;

    [SerializeField]
    private GameObject white3;

    [SerializeField]
    private GameObject white4;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateBlackRoutine());
        StartCoroutine(CreateRedRoutine());
        StartCoroutine(CreateWhite1Routine());
        StartCoroutine(CreateWhite2Routine());
        StartCoroutine(CreateWhite3Routine());
        StartCoroutine(CreateWhite4Routine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CreateBlackRoutine(){
        while(true){
             // 대기전 실행
            CreateBlack();
            yield return new WaitForSeconds(0.2f); //1초 대기
        }
    }

    private void CreateBlack(){
        Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(UnityEngine.Random.Range(0.0f,1.0f),1.1f,0));
        pos.z = 0.0f;
        Instantiate(black, pos, Quaternion.identity);
    }

    IEnumerator CreateRedRoutine(){
        while(true){
             // 대기전 실행
            CreateRed();
            yield return new WaitForSeconds(2); //1초 대기

        }
    }

    private void CreateRed(){
        Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(UnityEngine.Random.Range(0.0f,1.0f),1.1f,0));
        pos.z = 0.0f;
        Instantiate(red, pos, Quaternion.identity);
    }

    IEnumerator CreateWhite1Routine(){
        while(true){
             // 대기전 실행
            CreateWhite1();
            yield return new WaitForSeconds(0.5f); //1초 대기

        }
    }

    private void CreateWhite1(){
        Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(UnityEngine.Random.Range(0.0f,1.0f),1.1f,0));
        pos.z = 0.0f;
        Instantiate(white1, pos, Quaternion.identity);
    }

    IEnumerator CreateWhite2Routine(){
        while(true){
             // 대기전 실행
            CreateWhite2();
            yield return new WaitForSeconds(0.5f); //1초 대기

        }
    }

    private void CreateWhite2(){
        Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(UnityEngine.Random.Range(0.0f,1.0f),1.1f,0));
        pos.z = 0.0f;
        Instantiate(white2, pos, Quaternion.identity);
    }

    IEnumerator CreateWhite3Routine(){
        while(true){
             // 대기전 실행
            CreateWhite3();
            yield return new WaitForSeconds(0.5f); //1초 대기

        }
    }

    private void CreateWhite3(){
        Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(UnityEngine.Random.Range(0.0f,1.0f),1.1f,0));
        pos.z = 0.0f;
        Instantiate(white3, pos, Quaternion.identity);
    }
    IEnumerator CreateWhite4Routine(){
        while(true){
             // 대기전 실행
            CreateWhite4();
            yield return new WaitForSeconds(0.5f); //1초 대기

        }
    }

    private void CreateWhite4(){
        Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(UnityEngine.Random.Range(0.0f,1.0f),1.1f,0));
        pos.z = 0.0f;
        Instantiate(white4, pos, Quaternion.identity);
    }
}
