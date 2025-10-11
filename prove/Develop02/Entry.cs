public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;
    public string getRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(entries.Count);
        return entries[index];
    }
    List<string> entries = new List<string>
{
    "Did I make a difference tonight?",
    "What did I overlook in the case?",
    "Is Gotham better with me in it—or worse?",
    "How many lives did I save today?",
    "What did the criminal fear most—and why?",
    "Was my judgment clouded by emotion?",
    "Did I let vengeance guide my actions?",
    "How long can I keep doing this before I break?",
    "What would my parents say if they saw me now?",
    "Is the line between justice and obsession still clear?",
    "Did I go too far with him? Did he deserve mercy?",
    "What does Bruce Wayne offer the world that Batman can’t?",
    "Did I inspire anyone tonight—or just terrify them?",
    "How much longer can I fight alone?",
    "What would I do if Alfred were gone?",
    "Did I live up to my own code today?",
    "Are the criminals evolving—or am I falling behind?",
    "What am I most afraid of becoming?",
    "Is there still hope for Gotham… or just survival?",
    "Can Batman ever stop—and if he does, what happens next?"
};
}