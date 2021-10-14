interface IAggregator
{
    void Request(TaxiClient client);
    void Cancel(TaxiClient client);
}