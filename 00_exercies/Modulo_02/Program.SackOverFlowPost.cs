namespace Modulo_02
{
    internal partial class Program
    {
        private class SackOverFlowPost
        {
            public int Votes { get; private set; }

            public int VoteUp
            {
                set => Votes = Votes + 1;
            }

            public int VoteDown
            {
                set => Votes = Votes + 1;
            }
            
            
        }
    }
}