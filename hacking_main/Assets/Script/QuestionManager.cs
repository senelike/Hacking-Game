using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{
    public Text questionText;
    public InputField answerInput;
    public Button submitButton;
    public Text feedbackText;

    private List<Question> questions;
    private int currentQuestionIndex = 0;

    void Start()
    {
        questions = new List<Question>
        {
            new Question("Siber saldýrganlar genellikle __________ yöntemini kullanarak kullanýcýlarý kandýrmaya çalýþýr.", "phishing"),
            new Question("Bilgisayarýnýzý korumak için etkili bir __________ yazýlýmý kullanmanýz önemlidir.", "antivirüs"),
            new Question("__________, að trafiðini izleyerek yetkisiz eriþimleri engelleyen bir güvenlik önlemidir.", "firewall"),
            new Question("Beyaz þapkalý hackerlar, sistemi güvenli hale getirmek için __________ testleri yaparlar.", "sýzma"),
            new Question("Uzak sunuculara güvenli bir þekilde eriþmek için __________ protokolü kullanýlýr.", "ssh"),
            new Question("__________, internet trafiðini güvenli bir þekilde iletmek için kullanýlýr ve veri gizliliðini saðlar.", "vpn"),
            new Question("Sistemlere izinsiz eriþim saðlayan ancak bunu genellikle zararlý niyetle yapmayan ve tespit ettiði güvenlik açýklarýný bildirenlere ________ þapkalý hacker denir.", "gri"),
            new Question("Bir sistemi aþýrý yükleyerek hizmet vermesini engelleyen saldýrýya __________ saldýrýsý denir.", "ddos"),
            new Question("Linux'ta en yüksek yetkilere sahip olan kullanýcý __________ hesabýdýr.", "root"),
            new Question("Linux iþletim sisteminin çekirdeðine __________ denir.", "kernel")
        };

        DisplayNextQuestion();
        submitButton.onClick.AddListener(CheckAnswer);
    }

    void DisplayNextQuestion()
    {
        if (currentQuestionIndex < questions.Count)
        {
            questionText.text = questions[currentQuestionIndex].text;
            answerInput.text = "";
            feedbackText.text = "";
        }
        else
        {
            questionText.text = "Tebrikler! Tüm sorularý tamamladýnýz.";
            answerInput.gameObject.SetActive(false);
            submitButton.gameObject.SetActive(false);
        }
    }

    void CheckAnswer()
    {
        if (answerInput.text.ToLower() == questions[currentQuestionIndex].answer.ToLower())
        {
            feedbackText.text = "Doðru!";
            currentQuestionIndex++;
            DisplayNextQuestion();
        }
        else
        {
            feedbackText.text = "Yanlýþ, tekrar deneyin.";
        }
    }
}

[System.Serializable]
public class Question
{
    public string text;
    public string answer;

    public Question(string text, string answer)
    {
        this.text = text;
        this.answer = answer;
    }
}
