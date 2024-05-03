public class PromptGenerator {

    //public List<string> _prompts = new List<string>()
    private List<string> _prompts = new List<string>()
    {
        "How are you today?",
        "Do you have any hard thing happened today?",
        "Has anything really good happened to you today? ",
        "Have you ever been able to pray today?",
        "Talk about someone who was with you today, and helped you in some way?",
        "Tell me how you are feelling today: Bad, I need to recharge/ Good, I feel very good / More or less."
    };

    private List<String> _usedPrompts = new List<string>(); // List tp see prompts used

    public string GetRandomPrompt()
    {
        //Get random index and lookup the string in _prompts
        // Random random = new Random();
        // int index = random.Next(_prompts.Count); // Selects a random index within the range of the list
        // return _prompts[index]; // Returns the question corresponding to the random index

        // Rule to not repeat prompt questions until the program have scrolled trought the entire list of questions
        if ( _usedPrompts.Count == _prompts.Count)
        {
            //If all questions have been used, restart the list of questions used
            _usedPrompts.Clear();
        }

        if (_usedPrompts.Count == 0)
        {
            /// If the list of questions used is empty, shuffle the list of questions
            ShufflePrompts();
        }
        //Getting the Next Available Question in the Scrambled Questions List
        string nextPrompt = _usedPrompts[0];
        return nextPrompt;
    }
    private void ShufflePrompts()
    {
        //Shuffle the list of questions
        Random random = new Random();
        for (int i= _prompts.Count - 1; i > 0; i--)
        {
            int j = random.Next(0, i + 1);
            string temp = _prompts[i];
            _prompts[i] = _prompts[j];
            _prompts[j] = temp;
        }

        //Copy the shuffled list to the list of questions used
        _usedPrompts.AddRange(_prompts);
    }
}

