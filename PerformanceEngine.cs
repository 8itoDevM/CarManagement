using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PerformanceEngine : IEngine
{
    private bool isOn = false;
    
    public void TurnOn()
    {
        if (isOn)
        {
            Console.WriteLine("The engine is already on");
        }
        else
        {
            Console.WriteLine("Engine turned on");
            isOn = true;
        }
    }
    
    public void TurnOff()
    {
        if (!isOn)
        {
            Console.WriteLine("The engine is already off");
        }
        else
        {
            Console.WriteLine("Engine turned off");
            isOn = false;
        }
    }
    
    public bool IsOn()
    {
        return isOn;
    }
}

