using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game_Manager2 : MonoBehaviour
{

    public GameObject obj;
    public GameObject obj_side;

    int i;
    int j;
    int random_num;
    int count = 0;

    private Vector3 mousePos;
    private Camera cam;

    private GameObject target;
    public TMP_Text ScoreText;


    public int score = 50;


    // Start is called before the first frame update
    void Start()
    {
        
        float dis = 2.0f;


        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 3; j++)
            {

                count += 1;

                random_num = Random.Range(1, 10);
                Debug.Log(random_num);



                if (random_num % 2 == 1 )
                {
                    //������� ���
                    Instantiate(obj_side, new Vector3(i * dis - dis, j * dis - dis, 0), Quaternion.identity);

                }
                else
                {

                    //������ ���
                    Instantiate(obj, new Vector3(i * dis - dis, j * dis - dis, 0), Quaternion.identity);
                }


            }

        }

        
    }



    void Update()
    {
        ScoreText.text = score.ToString();




        if (Input.GetMouseButtonDown(0))
        {
            CastRay();

            Debug.Log("Ray!");


            /*
            if (target == this.gameObject)
            {  //Ÿ�� ������Ʈ�� ��ũ��Ʈ�� ���� ������Ʈ���

                // ���⿡ ������ �ڵ带 �����ϴ�.

            }
            */


        }

    }


    void CastRay() // ���� ��Ʈó�� �κ�.  ���̸� ���� ó��
    {

        target = null;
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);

        if (hit.collider != null)
        {
            //��Ʈ�Ǿ��ٸ� ���⼭ ����
            Debug.Log(hit.collider.name);  //�� �κ��� Ȱ��ȭ �ϸ�, ���õ� ������Ʈ�� �̸��� ���� ���ɴϴ�. 


            target = hit.collider.gameObject;  //��Ʈ �� ���� ������Ʈ�� Ÿ������ ����

            Destroy(target);                //Ÿ���� ���� �ϰ� ���� �� 

            if (hit.collider.name == "��rystal 1(Clone)")
            {
                Debug.Log("�δ��� Ŭ������!");
                score += 100;

            }
            else
            {

                Debug.Log("�߸� Ŭ���߽��ϴ�!");
                score -= 10;

            }

            Debug.Log(score);

        }

    }

}
