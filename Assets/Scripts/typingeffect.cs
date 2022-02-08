using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class typingeffect : MonoBehaviour
{
    public Text tx;
    private string m_text = "판타지 소설 속 이세계로 온 지 2주째.";
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_typing());
    }

IEnumerator _typing()
    {
        yield return new WaitForSeconds(0.1f);
        for(int i=0; i<=m_text.Length; i++)
        {
            tx.text = m_text.Substring(0, i);

            yield return new WaitForSeconds(0.15f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
