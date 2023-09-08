public class NPCFriendly : NPC
{
    public string text = "Hi there. Look out for that KOBOLD on the other side!";

    protected override string GetText()
    {
        return text;
    }
}
