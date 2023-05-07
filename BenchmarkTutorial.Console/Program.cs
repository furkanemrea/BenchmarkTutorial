// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkTutorial.Console;



BenchmarkRunner.Run<Tester>();

Console.ReadLine();


[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net60)]
[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net70)]
[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net80)]
[MemoryDiagnoser]
public class Tester
{
    [Benchmark]
    public int HandleWithNonSealedClass()
    {
        NotSealedClass notSealedClass = new NotSealedClass();
        return notSealedClass.Handle(5,10);
    }
    [Benchmark]
    public int HandleWithSealedClass()
    {
        SealedClass sealedClass = new SealedClass();
        return sealedClass.Handle(5,10);

    }
}


