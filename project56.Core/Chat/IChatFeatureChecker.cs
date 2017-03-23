namespace project56.Chat
{
    public interface IChatFeatureChecker
    {
        void CheckChatFeatures(int? sourceTenantId, int? targetTenantId);
    }
}
