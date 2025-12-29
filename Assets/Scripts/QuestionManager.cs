using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class QuestionManager : MonoBehaviour
{
    [SerializeField] private TMP_Text question;
    [SerializeField] private TMP_Text answer;

    [SerializeField] private TMP_Text question1;
    [SerializeField] private TMP_Text answer1;

    [SerializeField] private TMP_Text question2;
    [SerializeField] private TMP_Text answer2;

    [SerializeField] private TMP_Text question3;
    [SerializeField] private TMP_Text answer3;

    [SerializeField] private TMP_Text question4;
    [SerializeField] private TMP_Text answer4;

    [SerializeField] private TMP_Text question5;
    [SerializeField] private TMP_Text answer5;

    [SerializeField] private TMP_Text question6;
    [SerializeField] private TMP_Text answer6;

    [SerializeField] private TMP_Text question7;
    [SerializeField] private TMP_Text answer7;

    private Dictionary<int, string> questionDict = new Dictionary<int, string>();
    private Dictionary<int, string> answerDict = new Dictionary<int, string>();

    private void Awake()
    {
        FillDict();
        AssignQA();
    }

    private void FillDict()
    {
        // 1 q&a
        questionDict.Add(1, "What is \"Threat Hunting\" in cybersecurity?");
        answerDict.Add(1, "Proactive process of searching across networks, endpoints and datasets to identify threats.");

        questionDict.Add(2, "Who performs threat hunting?");
        answerDict.Add(2, "Specialized personnel with knowledge of attacker tactics and cybersecurity tools.");

        questionDict.Add(3, "What tools might a threat hunter use?");
        answerDict.Add(3, "Endpoint detection and response (EDR), network analyzers, custom scripts or rules.");

        questionDict.Add(4, "How do threat hunters stay effective?");
        answerDict.Add(4, "Learning new attack methods, analyzing incident reports, updating hunt hypotheses regularly");

        // 2 q&a
        questionDict.Add(5, "What is \"Threat Intelligence\" in cybersecurity?");
        answerDict.Add(5, "Collecting and analyzing information about cyber threats to help protect against attacks.");

        questionDict.Add(6, "What sources are used to gather threat intelligence?");
        answerDict.Add(6, "internal logs, open-source intelligence, dark web monitoring, partner sharing.");

        questionDict.Add(7, "What is OSINT in the context of threat intelligence?");
        answerDict.Add(7, "Information collected from publicly available sources, such as websites, forums, social media.");

        questionDict.Add(8, "What is a threat feed?");
        answerDict.Add(8, "List of threat-related data (malicious IPs, domains, hashes) that security tools use for automated detection and blocking.");

        // 3 q&a
        questionDict.Add(9, "Which type of attack involves an attacker inserting malicious code into a database query, potentially leading to the disclosure of sensitive data?");
        answerDict.Add(9, "SQL Injection");

        questionDict.Add(10, "How to prevent SQL Injection attacks?");
        answerDict.Add(10, "Parameterized queries or prepared statements so user input is treated strictly as data.");

        questionDict.Add(11, "What is a prepared statement in SQL?");
        answerDict.Add(11, "A way to safely execute SQL queries where user input is treated strictly as data");

        questionDict.Add(12, "What are Indicators of SQL Injection?");
        answerDict.Add(12, "Unusual database errors, unexpected data changes, or unauthorized access attempts.");

        // 4 q&a
        questionDict.Add(13, "The process of permanently and irrevocably altering sensitive data so that it cannot be reversed is known as?");
        answerDict.Add(13, "Data Hashing");

        questionDict.Add(14, "What is a brute force attack?");
        answerDict.Add(14, "Cracking passwords by systematically trying every possible combination.");

        questionDict.Add(15, "What is social engineering?");
        answerDict.Add(15, "Manipulating people to divulge confidential information, often through deception.");

        questionDict.Add(16, "What is the purpose of a Firewall?");
        answerDict.Add(16, "Monitors and controls incoming and outgoing traffic based on rules.");

        // 5 q&a
        questionDict.Add(17, "What is the security risk associated with 'oversharing' personal information on social media?");
        answerDict.Add(17, "It allows attackers to gather information for social engineering or to answer security questions.");

        questionDict.Add(18, "What is a honeypot?");
        answerDict.Add(18, "A decoy system designed to attract and analyze attacker behavior.");

        questionDict.Add(19, "What is ransomware?");
        answerDict.Add(19, "Malicious software that encrypts files and demands payment for decryption.");

        questionDict.Add(20, "What is encryption?");
        answerDict.Add(20, "Encryption transforms data into a coded format to prevent unauthorized access.");

        // 6 q&a
        questionDict.Add(21, "Why is it dangerous to ignore the 'S' in HTTPS when visiting a website for online shopping or banking?");
        answerDict.Add(21, "The connection to the website is not encrypted, allowing hackers to view your transmitted data.");

        questionDict.Add(22, "What is network sniffing?");
        answerDict.Add(22, "Intercepting and capturing network traffic to analyze or steal information.");

        questionDict.Add(23, "What is a DDoS attack?");
        answerDict.Add(23, "Flooding a server or network with excessive traffic from multiple sources.");

        questionDict.Add(24, "What is the purpose of a VPN?");
        answerDict.Add(24, "encrypts internet traffic, providing secure and private online access.");

        // 7 q&a
        questionDict.Add(25, "What does the acronym VPN stand for?");
        answerDict.Add(25, "Virtual private network.");

        questionDict.Add(26, "What is phishing?");
        answerDict.Add(26, "Cyberattack using deceptive emails or messages to trick users into giving sensitive information.");

        questionDict.Add(27, "What is the definition of Malware?");
        answerDict.Add(27, "software, such as viruses or ransomware, designed to harm or exploit systems.");

        questionDict.Add(28, "What is a digital signature?");
        answerDict.Add(28, "A cryptographic method that verifies the authenticity and integrity of digital documents.");

        // 8 q&a
        questionDict.Add(29, "Question 8.1");
        answerDict.Add(29, "Answer 8.1");

        questionDict.Add(30, "Question 8.2");
        answerDict.Add(30, "Answer 8.2");
    }

    private void AssignQA()
    {
        // 1
        int rng = Random.Range(1, 5);
        string q = questionDict[rng];
        string a = answerDict[rng];

        question.text = q;
        answer.text = a;

        // 2
        rng = Random.Range(5, 9);
        string q1 = questionDict[rng];
        string a1 = answerDict[rng];

        question1.text = q1;
        answer1.text = a1;

        // 3
        rng = Random.Range(9, 13);
        string q2 = questionDict[rng];
        string a2 = answerDict[rng];

        question2.text = q2;
        answer2.text = a2;

        // 4
        rng = Random.Range(13, 17);
        string q3 = questionDict[rng];
        string a3 = answerDict[rng];

        question3.text = q3;
        answer3.text = a3;

        // 5
        rng = Random.Range(17, 21);
        string q4 = questionDict[rng];
        string a4 = answerDict[rng];

        question4.text = q4;
        answer4.text = a4;

        // 6
        rng = Random.Range(21, 25);
        string q5 = questionDict[rng];
        string a5 = answerDict[rng];

        question5.text = q5;
        answer5.text = a5;

        // 7
        rng = Random.Range(25, 29);
        string q6 = questionDict[rng];
        string a6 = answerDict[rng];

        question6.text = q6;
        answer6.text = a6;

        // 8
        rng = Random.Range(29, 31);
        string bq = questionDict[rng];
        string ba = answerDict[rng];

        question7.text = bq;
        question7.text = ba;
    }
}
