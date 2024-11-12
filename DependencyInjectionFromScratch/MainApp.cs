namespace DependencyInjectionFromScratch;

public class MainApp
{
    private readonly ISomeService _someService;
    private readonly IRandonGuidProvider _randonGuidProvider;

    public MainApp(ISomeService someService, 
        IRandonGuidProvider randonGuidProvider)
    {
        _someService = someService;
        _randonGuidProvider = randonGuidProvider;
    }

    public async Task StartAsync()
    {
        _someService.PrintSomething();
        Console.WriteLine(_randonGuidProvider.RandomGuid.ToString());
    }
}