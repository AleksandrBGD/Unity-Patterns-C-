interface IGroup 
{
    void Add(IClient client);
    void Remove(IClient client);
    void Notify();
}