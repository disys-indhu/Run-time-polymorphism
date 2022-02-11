using System;
public class EmployeeOne
{
    public virtual void salary()
    {
        Console.WriteLine("EmployeeOne salary is 50,000");
    }
}
public class EmployeeTwo : EmployeeOne
{
    public override void salary()
    {
        base.salary();
        Console.WriteLine("EmployeeTwo salary is 60,000");
    }
}
public class TestOverriding
{
    public static void Main(string[] args)
    {
        EmployeeTwo e = new EmployeeTwo();
        e.salary();
    }
}
