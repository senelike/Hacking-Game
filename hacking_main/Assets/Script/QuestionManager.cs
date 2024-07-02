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
            new Question("Siber sald�rganlar genellikle __________ y�ntemini kullanarak kullan�c�lar� kand�rmaya �al���r.", "phishing"),
            new Question("Bilgisayar�n�z� korumak i�in etkili bir __________ yaz�l�m� kullanman�z �nemlidir.", "antivir�s"),
            new Question("__________, a� trafi�ini izleyerek yetkisiz eri�imleri engelleyen bir g�venlik �nlemidir.", "firewall"),
            new Question("Beyaz �apkal� hackerlar, sistemi g�venli hale getirmek i�in __________ testleri yaparlar.", "s�zma"),
            new Question("Uzak sunuculara g�venli bir �ekilde eri�mek i�in __________ protokol� kullan�l�r.", "ssh"),
            new Question("__________, internet trafi�ini g�venli bir �ekilde iletmek i�in kullan�l�r ve veri gizlili�ini sa�lar.", "vpn"),
            new Question("Sistemlere izinsiz eri�im sa�layan ancak bunu genellikle zararl� niyetle yapmayan ve tespit etti�i g�venlik a��klar�n� bildirenlere ________ �apkal� hacker denir.", "gri"),
            new Question("Bir sistemi a��r� y�kleyerek hizmet vermesini engelleyen sald�r�ya __________ sald�r�s� denir.", "ddos"),
            new Question("Linux'ta en y�ksek yetkilere sahip olan kullan�c� __________ hesab�d�r.", "root"),
            new Question("Linux i�letim sisteminin �ekirde�ine __________ denir.", "kernel")
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
            questionText.text = "Tebrikler! T�m sorular� tamamlad�n�z.";
            answerInput.gameObject.SetActive(false);
            submitButton.gameObject.SetActive(false);
        }
    }

    void CheckAnswer()
    {
        if (answerInput.text.ToLower() == questions[currentQuestionIndex].answer.ToLower())
        {
            feedbackText.text = "Do�ru!";
            currentQuestionIndex++;
            DisplayNextQuestion();
        }
        else
        {
            feedbackText.text = "Yanl��, tekrar deneyin.";
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
