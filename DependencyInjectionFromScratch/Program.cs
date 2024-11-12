// See https://aka.ms/new-console-template for more information

using DependencyInjectionFromScratch;
using DependencyInjectionFromScratch.DependencyInjection;

var services = new DiServiceCollection();

// services.RegisterSingleton<RandomGuidGenerator>();
// services.RegisterTransient<RandomGuidGenerator>();
services.RegisterTransient<ISomeService, SomeServiceOne>();
services.RegisterSingleton<IRandonGuidProvider, RandonGuidProvider>();
services.RegisterSingleton<MainApp>();


var container = services.GenerateContainer();

var serviceFirst = container.GetService<ISomeService>();
var serviceSecond = container.GetService<ISomeService>();
var mainApp = container.GetService<MainApp>();

// serviceFirst.PrintSomething();
// serviceSecond.PrintSomething();

await mainApp.StartAsync();