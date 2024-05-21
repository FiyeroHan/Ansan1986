using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreManager : MonoBehaviour
{

    static public int score = 1500;

    public enum ScoreCategory
    {
        routing, //���� �ؼ�
        speed, // �ӵ� �ؼ�
        stop, // ������ġ �ؼ�
        turnSignal, // ������ �ؼ�
        time, // Ÿ�Ӿ��� ������
        passanger, // �°� ��������
        accident // �������
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Scoring(ScoreCategory CategoryName)
    {
        if(CategoryName == ScoreCategory.routing) score += 10;
        else if (CategoryName == ScoreCategory.speed) score += 10;
        else if (CategoryName == ScoreCategory.stop) score += 300;
        else if (CategoryName == ScoreCategory.turnSignal) score += 150;
        else if (CategoryName == ScoreCategory.time) score += 700;
        else if (CategoryName == ScoreCategory.passanger) score += 300;
        else if (CategoryName == ScoreCategory.accident) score -= 200;
    
    }
        
}
