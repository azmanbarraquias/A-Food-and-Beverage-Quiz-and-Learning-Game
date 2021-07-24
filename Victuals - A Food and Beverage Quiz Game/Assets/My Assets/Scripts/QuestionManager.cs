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
    public TextMeshProUGUI questionCountTMPro;
    [Space]
    public GameObject[] asnwerButton;
    private int correctAnswerIndex;
    public Button fiftyfiftyBtn;
    public Button livesBtn;

    [Space]

    // store the ununansweredQuestions.
    // Static so that when we reload the next scene it will remember the questions...
    private static List<Question> unansweredQuestions;

    private Question currentQuestion; //this will store question after get the random question

    // store the correct question
    private int currentNoQestion;

    public GameObject lives;

    // Start is called before the first frame update
    void Start()
    {
        currentNoQestion = questions.Length;
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

        // Get the random question index from list from unansweredQuestions
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);

        // lets select the question base on index
        currentQuestion = unansweredQuestions[randomQuestionIndex];

        questionCountTMPro.text = (currentNoQestion--) + " / " + questions.Length; // 1++ / totalQuestions


        // remove question after set that current question from unansweredQuestion list
        unansweredQuestions.RemoveAt(randomQuestionIndex);

        // Set info to UI Text
        questionTMPro.text = currentQuestion.question.question;

        asnwerATMPro.text = currentQuestion.question.answerA;
        asnwerBTMPro.text = currentQuestion.question.answerB;
        asnwerCTMPro.text = currentQuestion.question.answerC;
        asnwerDTMPro.text = currentQuestion.question.answerD;
    }
    #endregion GetRandomQuestionMethod

    #region Buttons
    public void SelectButtonA()
    {
        if (currentQuestion.question.asnwerIsA == true)
        {

        }
        else
        {
            DoubleChanceUI();

            CheckLives();
        }
        GetRandomQuestion();
    }

    public void SelectButtonB()
    {
        if (currentQuestion.question.asnwerIsB == true)
        {

        }
        else
        {
            DoubleChanceUI();

            CheckLives();

        }
        if (true)
        {

        }
        GetRandomQuestion();

    }

    public void SelectButtonC()
    {
        if (currentQuestion.question.asnwerIsC == true)
        {

        }
        else
        {
            DoubleChanceUI();

            CheckLives();
        }
        GetRandomQuestion();

    }

    public void SelectButtonD()
    {
        if (currentQuestion.question.asnwerIsD == true)
        {

        }
        else
        {
            DoubleChanceUI();

            CheckLives();
        }
        GetRandomQuestion();

    }
    #endregion Buttons

    void CheckLives()
    {
        if (lives.transform.childCount == 1)
        {
            //death
        }
        else
        {
            Destroy(lives.transform.GetChild(0).gameObject);
        }
    }

    public void RemoveTwoWrongAnswer()
    {
        fiftyfiftyBtn.interactable = false;

        if (currentQuestion.question.asnwerIsA == true)
        {
            correctAnswerIndex = 0;
        }
        if (currentQuestion.question.asnwerIsB == true)
        {
            correctAnswerIndex = 1;
        }
        if (currentQuestion.question.asnwerIsC == true)
        {
            correctAnswerIndex = 2;
        }
        if (currentQuestion.question.asnwerIsD == true)
        {
            correctAnswerIndex = 3;
        }

        for (int i = 0; i < asnwerButton.Length; i++)
        {
            if (i == correctAnswerIndex)
            {
                continue;
            }

            asnwerButton[i].GetComponent<Button>().interactable = false;
        }

        do
        {
            int randomIndex = Random.Range(0, 4);
            if (randomIndex == correctAnswerIndex)
            {
                continue;
            }
            else
            {
                asnwerButton[randomIndex].GetComponent<Button>().interactable = true;
                break;
            }

        } while (true);


    }

    public void EnableAnswerButton()
    {
        foreach (var button in asnwerButton)
        {
            button.GetComponent<Button>().interactable = true;
        }
    }

    public void DoubleChances()
    {

    }

    public void DoubleChanceUI()
    {

    }

    public void LoadDoubleChancesQuestion()
    {

    }
}
