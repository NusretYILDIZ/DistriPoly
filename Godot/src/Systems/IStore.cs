namespace DP.Systems;

public interface IStore
{
    void Buy(IStoreItem item);
    void Sell(IStoreItem item);
}