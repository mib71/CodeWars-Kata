// See https://aka.ms/new-console-template for more information
Console.WriteLine(HowMuchILoveYou(2));

static string HowMuchILoveYou(int v)
{
    return new string[] { "I love you", "a little", "a lot", "passionately", 
        "madly", "not at all" }[(v - 1) % 6];

    /* First try
    string[] phrases = { "I love you", "a little", "a lot", "passionately", "madly", "not at all" };

    int loops = 0;
    if (v > phrases.Length)
    {
        loops = (v / phrases.Length);
        v = (phrases.Length * loops - v) * -1;
        if (v == 0) v = 6;
    }

    return phrases[v - 1];
    */

}
