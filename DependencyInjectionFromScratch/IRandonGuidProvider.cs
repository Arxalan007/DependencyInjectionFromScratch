namespace DependencyInjectionFromScratch;

public interface IRandonGuidProvider
{
    Guid RandomGuid { get; }
}

public class RandonGuidProvider : IRandonGuidProvider
{
    public Guid RandomGuid { get; } = Guid.NewGuid();
}