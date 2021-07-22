using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Linq;

public class QuestionManager : MonoBehaviour
{
    [Header("Set Question")]
    public Question[] questions;
    [Space]
    public TextMeshProUGUI questionTMPro;
    [Space]
    public TextMeshProUGUI asnwerATMPro;
    public TextMeshProUGUI asnwerBTMPro;
    public TextMeshProUGUI asnwerCTMPro;
    public TextMeshProUGUI asnwerDTMPro;
    
    [Space]
    // store the ununansweredQuestions.
    // Static so that when we reload the next scene it will remember the questions...
    private static List<Question> unansweredQuestions;

    private Question currentQuestion; //this will store question after get the random question

     // store the correct question
    private int currentNoQestion;


    // Start is called before the first frame update
    void Start()
    {
        GetRandomQuestion(); // When start the game we want to load the questions
    }

    #region GetRandomQuestionMethod
    void GetRandomQuestion()
    {
        // but first check is the unansweredQuestion is finish then we must load all the question to unansweredQuestions
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            // store to a list of unansweredQuestions <<< questions
            unansweredQuestions = questions.ToList<Question>();
        }

       // questionNoInfo.text = (++currentNoQestion) + " / " + questions.Length; // 1++ / totalQuestions

        // Get the random question index from list from unansweredQuestions
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);

        // lets select the question base on index
        currentQuestion = unansweredQuestions[randomQuestionIndex];

        // remove question after set that current question from unansweredQuestion list
        unansweredQuestions.RemoveAt(randomQuestionIndex);

        // Set info to UI Text
        questionTMPro.text = currentQuestion.question.question;

        asnwerATMPro.text = currentQuestion.question.answerA;
        asnwerATMPro.text = currentQuestion.question.answerB;
        asnwerATMPro.text = currentQuestion.question.answerC;
        asnwerATMPro.text = currentQuestion.question.answerD;

    }
    #endregion GetRandomQuestionMethod

    #region Buttons
    public void SelectButtonA()
    {
        if (currentQuestion.question.asnwerIsA == true)
        {
            //total++;

            //aSource.Stop();
            //aSource.clip = correctSound;
            //aSource.Play();
            //answer.SetTrigger("Correct");
        }
        else
        {
            //aSource.Stop();
            //aSource.clip = wrongSound;
            //aSource.Play();
            //answer.SetTrigger("Wrong");
            //if (correctImgAnswer != null)
            //{
            //    correctImgAnswer.sprite = currentQuestion.correctIMG;
            //}
        }
    }

    public void SelectButtonB()
    {
        if (currentQuestion.question.asnwerIsA == true)
        {
            //total++;

            //aSource.Stop();
            //aSource.clip = correctSound;
            //aSource.Play();
            //answer.SetTrigger("Correct");
        }
        else
        {
            //aSource.Stop();
            //aSource.clip = wrongSound;
            //aSource.Play();
            //answer.SetTrigger("Wrong");
            //if (correctImgAnswer != null)
            //{
            //    correctImgAnswer.sprite = currentQuestion.correctIMG;
            //}
        }
    }

    public void SelectButtonC()
    {
        if (currentQuestion.question.asnwerIsA == true)
        {
            //total++;

            //aSource.Stop();
            //aSource.clip = correctSound;
            //aSource.Play();
            //answer.SetTrigger("Correct");
        }
        else
        {
            //aSource.Stop();
            //aSource.clip = wrongSound;
            //aSource.Play();
            //answer.SetTrigger("Wrong");
            //if (correctImgAnswer != null)
            //{
            //    correctImgAnswer.sprite = currentQuestion.correctIMG;
            //}
        }
    }

    public void SelectButtonD()
    {
        if (currentQuestion.question.asnwerIsA == true)
        {
            //total++;

            //aSource.Stop();
            //aSource.clip = correctSound;
            //aSource.Play();
            //answer.SetTrigger("Correct");
        }
        else
        {
            //aSource.Stop();
            //aSource.clip = wrongSound;
            //aSource.Play();
            //answer.SetTrigger("Wrong");
            //if (correctImgAnswer != null)
            //{
            //    correctImgAnswer.sprite = currentQuestion.correctIMG;
            //}
        }
    }
    #endregion Buttons


}
