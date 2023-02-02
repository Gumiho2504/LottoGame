using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public List<int> number = new List<int>();
    public List<Text> numberTxt = new List<Text>();
    public List<Image> ballImage = new List<Image>();
    public List<Sprite> ballSprite = new List<Sprite>();
    public Sprite ballsprite;
    public Animator class1,class2,class3,class4,class5;
    public GameObject[] resultBall;
    public GameObject[] resultNumber;
    //private int range;
    //bool state = false;
    //int count = 0;
    //int n1,n2,n3,n4,n5;

    private void Start()
    {
       
    }
   /* private void Update()
    {
         if(state && count<5)
        {
            int random = Random.Range(1, 10);
           
            
            count++;
            switch (count){
                case 1:
                    n1= random;
                    print("n1 :" + n1);
                    break;
                case 2:
                    n2= random;
                    print("n2 :" + n2);
                    break;
                case 3:
                    n3= random;
                    print("n3 :" + n3);
                    break;
                case 4:
                    n4= random;
                    print("n4 :" + n4);
                    break;
                case 5:
                    n4 = random;
                    print("n5 :" + n5);
                    break;
            }
            StartCoroutine(RestartState());
            print(count);

        } 
    }*/

    public void Play()
    {

        //Ball.Play("Move");
        while (number.Count < 5)
        {
            int range = Random.Range(1, 10);
            number.Add(range);
        }
        print(string.Join(",", number));
        StartCoroutine(RestartState());
        
    }

   /* public void Play2()
    {
        state= true;
       
        
    }*/

    public void MatchhingImage()
    {
        for (int i = 0; i < 5; i++)
        {

            numberTxt[i].text = number[i].ToString();
            if (number[i] == 1)
            {
                ballImage[i].sprite = ballSprite[0];
            }
            else if (number[i] == 2)
            {
                ballImage[i].sprite = ballSprite[1];
            }
            else if (number[i] == 3)
            {
                ballImage[i].sprite = ballSprite[2];
            }
            else if (number[i] == 4)
            {
                ballImage[i].sprite = ballSprite[3];
            }
            else if (number[i] == 5)
            {
                ballImage[i].sprite = ballSprite[4];
            }
            else if (number[i] == 6)
            {
                ballImage[i].sprite = ballSprite[5];
            }
            else if (number[i] == 7)
            {
                ballImage[i].sprite = ballSprite[6];
            }
            else if (number[i] == 8)
            {
                ballImage[i].sprite = ballSprite[7];
            }
            else if (number[i] == 9)
            {
                ballImage[i].sprite = ballSprite[8];
            }


        }
    }

    IEnumerator RestartState()
    {
        //yield return new WaitForSeconds(2f);
        MatchhingImage();
        class1.Play("move1");
        yield return new WaitForSeconds(1f);
        resultBall[0].SetActive(true);
        resultNumber[0].SetActive(true);

        yield return new WaitForSeconds(1f);
        class2.Play("move2");
        yield return new WaitForSeconds(1f);
        resultBall[1].SetActive(true);
        resultNumber[1].SetActive(true);

        yield return new WaitForSeconds(1f);
        class3.Play("move3");
        yield return new WaitForSeconds(1f);
        resultBall[2].SetActive(true);
        resultNumber[2].SetActive(true);

        yield return new WaitForSeconds(1f);
        class4.Play("move4");
        yield return new WaitForSeconds(1f);
        resultBall[3].SetActive(true);
        resultNumber[3].SetActive(true);

        yield return new WaitForSeconds(1f);
        class5.Play("move5");
        yield return new WaitForSeconds(1f);
        resultBall[4].SetActive(true);
        resultNumber[4].SetActive(true);
        //for(int i=0; i<5; i++)
        //{
        //    resultBall[i].SetActive(true);
        //}
        yield return new WaitForSeconds(2f);
       // Ball.Play("idle");
        SceneManager.LoadScene(0);
        


    }
    public void QuitButton()
    {
        Application.Quit();
    }

    public void SettingButton()
    {
        Time.timeScale = 0;
    }
    public void CancelButtonSetting()
    {
        Time.timeScale = 1;
    }


}//end of class
