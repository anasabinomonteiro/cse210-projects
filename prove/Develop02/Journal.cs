public class Journal 
{// list -  piece of data
    public List<Entry> _entries = new List<Entry>();

// 4 functions
    public void AddEntry(Entry newEntry)
    {
        // New Entry into _entries
        _entries.Add(newEntry);

    }

    public void DisplayAll()
    {
        //Display all entries in the _entries list
        foreach (Entry entry in _entries)

        entry.Display();

    }

    public void SaveToFile(string filename)
    {
        // Save to file each item in _entries (.txt, .csv, .json, etc..)
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}, {entry._prompText}, {entry._entryText}");

            }
        }
    }

    public void LoadFromFile(string filename)
    {
        // Load from a existent file and create Entry objecsts to put in the List(Entry).
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 3)
                {
                    string date = parts[0];
                    string prompText = parts[1];
                    string entryText = parts[2];  
                    Entry newEntry = new Entry
                    {
                        _date = date,
                        _prompText = prompText,
                        _entryText = entryText
                    };

                    _entries.Add(newEntry);
                }
                
            }
        }

    }

}