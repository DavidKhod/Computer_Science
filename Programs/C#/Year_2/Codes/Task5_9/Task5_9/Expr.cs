public class Expr
{
    private int num1;
    private int num2;
    private char op;

    public Expr(int num1,int num2,char op)
    {
        this.num1 = num1;
        this.num2 = num2;
        this.op = op;
    }

    public int Num1
    {
        get { return this.num1; }
        set { this.num1 = value; }
    }

    public int Num2
    {
        get { return this.num2; }
        set { this.num2 = value; }
    }

    public char Op
    {
        get { return this.op; }
        set { this.op = value; }
    }

    public double Calculate()
    {
        switch (this.op)
        {
            case '*':
                return num1 * num2;
            case '/':
                return num1 / num2;
            case '+':
                return num1 + num2;
            default:
                return num1 - num2;
        }
    }

    public override string ToString()
    {
        return $"{num1} {op} {num2}";
    }
}

