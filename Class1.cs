using System;

public class Student
{
    private int ID;
    private string Name;
    private Test Score;

    public static int count;

    public Student(int ID, string n, int m, int f)
    {
        ID = ID;
        Name = n;
        Score = new Test (m, f);
    }

    public string GotStuden()
    {
        string str;
        str = "學生編號: " + ID.ToString();
        str += "\n學生姓名: " + Name;
        str += "\n期終考成績:" + Score.GetMid().ToString();
        str += "\n期中考成績:" + Score.GetFinal().ToString();
        str += "\n平均成績" + Score.GetAvg().ToString();

        return str;
    }

}
