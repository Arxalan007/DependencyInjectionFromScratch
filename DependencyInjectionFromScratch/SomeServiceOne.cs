namespace DependencyInjectionFromScratch;

public class SomeServiceOne : ISomeService
{
    private readonly IRandonGuidProvider _randonGuidProvider;
    // private readonly Guid RandomGuid = Guid.NewGuid();

    public SomeServiceOne(IRandonGuidProvider randonGuidProvider)
    {
        _randonGuidProvider = randonGuidProvider;
    }

    public void PrintSomething()
    {
        Console.WriteLine(_randonGuidProvider.RandomGuid);
    }
}