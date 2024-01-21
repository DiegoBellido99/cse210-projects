using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;


public class Journal 
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }
    
    public void AddEntry()
    {
        PromptGenerator promptGenerator = new PromptGenerator();

        string pregunta = promptGenerator.GetRandonPrompt();
        Console.WriteLine(pregunta);
        string Text = Console.ReadLine();


        DateTime theCurrentTime = DateTime.Now;
        string fecha = theCurrentTime.ToShortDateString();


        Entry entrada = new Entry(theCurrentTime,pregunta,Text);
    
        _entries.Add(entrada);
    }

    public void DisplayAll() 
    {
       foreach(var answer in _entries)
       {
            answer.Display();
            Console.WriteLine();
       }
    }

    public void SaveToField()
    {    
        Console.WriteLine("What is the name de file?");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(var entry in _entries)
            {
                outputFile.WriteLine($"{entry._date.ToShortDateString()}, {entry._promptText}, {entry._entryText}");
            }

        }
    }

    public void LoadFroamFile( string fileName)
    {

        using (StreamReader inputFile = new StreamReader(fileName))

                {

                    while (!inputFile.EndOfStream)

                    {

                        string line = inputFile.ReadLine();

                        string[] parts = line.Split(',');

                        if (parts.Length == 3)

                        {

                            DateTime date = DateTime.Parse(parts[0].Trim());

                            string promptText = parts[1].Trim();

                            string entryText = parts[2].Trim();

        

                            Entry entry = new Entry(date, promptText, entryText);

                            _entries.Add(entry);

                        }

                    }

                }
        
    }  

    public void DeleteLine(string FileName)
    {
        string file = FileName;
        List<string> line = File.ReadAllLines(FileName).ToList();

        if(line.Count > 0)
        {
            line.RemoveAt(line.Count -1);
            File.WriteAllLines(file, line);
            Console.WriteLine("The last line was delete");
        }
    }
}