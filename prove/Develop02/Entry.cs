public class Entry
 {    
    public string _date;
    public string _prompText;
    public string _entryText;

     // function
    public void Display()
    {
        Console.WriteLine($"{_date} : {_prompText}"); 
        Console.WriteLine(_entryText);
    }
}