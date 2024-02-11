using System.Linq.Expressions;

public class GoalManager
{
    protected List<Goal> goals;
    protected int _score;

    protected List<string> prompts;

    public GoalManager()
    {
        goals = new List<Goal>();
    }

    public void Start ()
    {
        int choice = 1;
        while ( choice != 6)
        {
            Console.WriteLine();
            DisplayPlayerInfo();
            Console.WriteLine("Menu options: ");
            Console.WriteLine("1-Creat a new Goal");
            Console.WriteLine("2-List of Goals ");
            Console.WriteLine("3-Save  Goals. ");        
            Console.WriteLine("4-Load Goals .");
            Console.WriteLine("5-Record Event .");
            Console.WriteLine("6-Quit. ");
    
            Console.Write("Select a choice from the menu :");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();
            

            if (choice == 1 )
            {
                Console.WriteLine("The types of goals are :");
                Console.WriteLine("1-Simple Goal.");
                Console.WriteLine("2-Eternal Goal.");
                Console.WriteLine("3-Checklist Goal.");
                Console.WriteLine("4-Random Goal");
                Console.Write("Which Type of goal would you  like to create ? :");
                int typeusers = int.Parse(Console.ReadLine());
                CreateGoal(typeusers);

            }

            else if ( choice == 2)
            {
                ListGoalDetails();
                Console.WriteLine();
            }

            else if (choice == 3)
            {
                SaveGoal();
            }

            else if (choice == 4)
            {
                Console.Write("What is the fiel for the goal fiel? : ");
                string goalFiel = Console.ReadLine();
                LoadFroamFile(goalFiel);
            }
            else if (choice == 5)
            {
                Console.Write("Which goal did you accomplish? : ");
                int indexgoal = int.Parse(Console.ReadLine())-1;

                Goal goalCompleted= goals[indexgoal];
                RecordEvent(goalCompleted);

                int valor=goalCompleted.GetPoints();
                _score = _score+ valor;

                Console.WriteLine($"Congratulations!!! You earn {valor}  ");
                Console.WriteLine($"You now have {_score} points.");
                Console.WriteLine();               
            }   

        }
    }

    public void  DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points. ");
    }

    public void  ListGoalNames()
    {
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"- {goal.GetShortName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("List of Goal Details:");
        int number = 1;
        foreach (Goal goal in goals)
        {
            string checkbox = goal.Iscomplete() ? "[X]" : "[ ]";
            string details = goal.GetDetailsString();
            Console.WriteLine($"{number}-{checkbox} {details}");
            number = number +1;
        }

    }

    public void CreateGoal(int type )
    {
        if (type == 1)
        {
            Console.Write("What is the name of your goal? :");
            string shortname = Console.ReadLine();
            Console.Write("What is a short description of it? :");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal?:");
            int point = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Goal goal= new SimpleGoal(shortname,description,point);
            
            goals.Add(goal);
        } 

        else if (type == 2)
        {
            Console.Write("What is the name of your goal? :");
            string shortname = Console.ReadLine();
            Console.Write("What is a short description of it? :");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal?:");
            int point = int.Parse(Console.ReadLine());
            Goal goal= new EternalGoal(shortname,description,point);
            
            goals.Add(goal);
        } 

        else if (type == 3)
        {
            Console.Write("What is the name of your goal?: ");
            string shortname = Console.ReadLine();
            Console.Write("What is a short description of it?: ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal?: ");
            int point = int.Parse(Console.ReadLine());
            Console.Write("How many times does this goal need to accomplished for a bonus ?: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            Goal goal= new CheckListGoal(shortname,description,point,target,bonus,0);
            
            goals.Add(goal);            
        }  
        else if (type == 4)
        {
            string prompts = SetDescription();
            Goal goal = new RamdonGoal("Ramdon Goal",prompts,50);

            Console.WriteLine("You created a ramdon goal !!");

            goals.Add(goal);
        }

        else
        {
            Console.WriteLine("Choise no valited");
        }
    }

    public void SaveGoal()
    {
        Console.Write("What is the name de file?: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);

            foreach(Goal goal in goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }

        }        
    }

    public void LoadFroamFile(string fileName)
    {
        string [] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines )
        {
            string [] parts = line.Split(',',':');

            if (parts.Length == 1)
            {
                int presentscore =int.Parse(parts[0].Trim());
                _score= presentscore;
            }

            else if (parts.Length == 5)
            {
                string  shortname = parts[1].Trim();
                string description = parts[2].Trim();
                int points =  int.Parse(parts[3].Trim());
                bool iscomplete = Convert.ToBoolean(parts[4].Trim());
                bool state= true;

                Goal goal = new SimpleGoal (shortname,description,points);
                if(iscomplete == state )
                {
                    goal.RecordEvent();
                    goals.Add(goal);
                }
                else
                {
                    goals.Add(goal);
                    
                }
            }
            
            else if (parts.Length == 4)
            {
                string  shortname = parts[1].Trim();
                string description = parts[2].Trim();
                int points =  int.Parse(parts[3].Trim()); 
                Goal goal = new EternalGoal (shortname,description,points);
                goals.Add(goal);              
            }
            else if (parts.Length == 6)
            {
                string shortname = parts[0].Trim();
                string description = parts[3].Trim();
                int points =  int.Parse(parts[4].Trim());
                bool iscomplete = Convert.ToBoolean(parts[5].Trim());
                bool state= true;

                Goal goal = new RamdonGoal (shortname,description,points);
                if(iscomplete == state )
                {
                    goal.RecordEvent();
                    goals.Add(goal);
                }
                else
                {
                    goals.Add(goal);
                    
                }                
            }

            else if ( parts.Length == 7)
            {
                string  shortname = parts[1].Trim();
                string description = parts[2].Trim();
                int points =  int.Parse(parts[3].Trim()); 
                int bonus = int.Parse(parts[4].Trim());
                int target = int.Parse(parts[5].Trim());
                int amount = int.Parse(parts[6].Trim());
                
                Goal goal = new CheckListGoal(shortname,description,points,target,bonus,amount);

                goals.Add(goal);
            }
        }        
    }

    public void RecordEvent(Goal goal)
    {
        goal.RecordEvent();
    }

    public string SetDescription()
    {
         prompts = new List<string>
        {
            "Complete a 20-minute High-Intensity Interval Training (HIIT) workout.",
            "Consume at least 2 liters of water throughout the day keeping track of your intake.",
            "Include a serving of leafy green vegetables in each meal.",
            "Write a thank-you letter to someone important in your life and share it with them.",
            "Give food to someone who lacks money",
            "Practice 10 minutes of guided meditation for relaxation.",
            "Read a chapter from a book related to your personal or professional development.",
            "Set a limit of 30 minutes on social media today.",
            "Create a list of 3 short-term and 3 long-term goals to work on in the future.",
            "Disconnect from electronic devices at least 1 hour before bedtime and read a physical book."
        };
        if (prompts.Count > 0)
        {
         Random random = new Random();
         int randomIndex = random.Next(0, prompts.Count);

         return prompts[randomIndex];
        }
         else
         {
            Console.WriteLine("There arent questions");
            return string.Empty;
         }
    }

}