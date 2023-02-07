namespace ReverseAndNot;

public class ReverseAndNot
{
    public string Run(int input) => string.Join(string.Empty, input.ToString().Reverse()) + input.ToString();
}