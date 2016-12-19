namespace Discord.Audio
{
    public class InternalIsSpeakingEventArgs
    {
        public ulong UserId { get; }
        public bool IsSpeaking { get; }

        public InternalIsSpeakingEventArgs(ulong userId, bool isSpeaking)
        {
            UserId = userId;
            IsSpeaking = isSpeaking;
        }
    }
}
