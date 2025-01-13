namespace oop_interview_test_1;

public class A
{
    private IB _b;

    public A(IB b)
    {
        _b = b;    
    }
}

public interface IB
{
    void Method();
}

public class B : IB
{
    public void Method()
    {
        
    }
}