using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, string> courses = new Dictionary<string, string>();
        string input;
        while ((input = Console.ReadLine()) != "end of contests")
        {
            string[] courseAndPass = input.Split(':');
            courses.Add(courseAndPass[0], courseAndPass[1]);
        }
        List<Candidate> participiants = new List<Candidate>();
        while ((input = Console.ReadLine()) != "end of submissions")
        {
            List<string> action = input.Split("=>").ToList();
            if (courses.ContainsKey(action[0]))
            {
                if (courses[action[0]] == action[1])
                {
                    if (participiants.Count == 0)
                    {
                        participiants.Add(new Candidate(action[2], action[0], int.Parse(action[3])));
                    }
                    else
                    {
                        bool exist = false;
                        foreach (var person in participiants)
                        {
                            if (person.Name == action[2])
                            {
                                exist = true;
                                person.UpdateScore(action[0], int.Parse(action[3]));
                                break;
                            }
                        }
                        if (!exist)
                        {
                            participiants.Add(new Candidate(action[2], action[0], int.Parse(action[3])));
                           // break;
                        }
                    }
                }
            }
        }
        string name = "";
        int score = 0;
        foreach (var people in participiants)
        {
            int tempScore = people.ScoreSum();
            if (score < tempScore)
            {
                score = tempScore;
                name = people.Name;
            }
        }
        Console.WriteLine($"Best candidate is {name} with total {score} points.");
        Console.WriteLine("Ranking:");
        foreach (var student in participiants.OrderBy(x=>x.Name))
        {
            Console.WriteLine($"{student.Name}");
            foreach (var course in student.courses.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine($"#  {course.Key} -> {course.Value}");
            }
        }
    }
}
class Candidate
{
    public string Name;
    public Dictionary<string, int> courses = new Dictionary<string, int>();
    public Candidate(string name, string course, int score)
    {
        Name = name;
        courses.Add(course, score);
    }
    public void UpdateScore(string course, int score)
    {
        if (courses.ContainsKey(course))
        {
            if (courses[course] < score)
            {
                courses[course] = score;
            }
        }
        else
        {
            courses.Add(course, score);
        }
    }
    public int ScoreSum()
    {
        int sum = 0;
        foreach (int number in courses.Values)
        {
            sum += number;
        }
        return sum;
    }
}
