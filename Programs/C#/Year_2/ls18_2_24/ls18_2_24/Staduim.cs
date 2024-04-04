using MyLib;
using System;

public class Staduim
{
    static Random rnd = new Random();
    private const int GATES = 12;
    private string name;
    private int maxCapacity;
    private Queue<string> restroomQ;
    private Queue<string>[] gates;

    public Staduim(string name, int maxCapacity)
    {
        this.name = name;
        this.maxCapacity = maxCapacity;
        this.restroomQ = new Queue<string>()//Creating a new empty queue
        gates = new Queue<string>[GATES];//Create an array of empty queues in the length of GATES
        for (int i = 0; i < GATES; i++)
            gates[i] = new Queue<string>();//Creating empty queues
    }

    public void QueueToRestroom(string id)
    {
        restroomQ.Insert(id);
    }

    //takes out and returns the RestroomQ firs "user"
    public string UseRestoom()
    {
        return restroomQ.Remove();
    }

    public void QueueInGate(string id, int gate)
    {
        gates[gate - 1].Insert(id);
    }

    public int EnterToGate(int gateIndex)
    {
        int num = rnd.Next(11);
        int cnt = num;
        while (!gates[gateIndex - 1].IsEmpty() && num > 0)
        {
            Console.WriteLine($"Entered: {gates[gateIndex].Remove().ToString()}");
            cnt --;
        }
        return num;
    }


}