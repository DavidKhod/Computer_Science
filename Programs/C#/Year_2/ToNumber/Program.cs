static int ToNumber(Queue<int> q)
{
    return ToNumber(q,10);
}

static int ToNumber(Queue<int> q, int times)
{
    if (q.IsEmpty()) { return 0; }
    return q.Remove()*times + ToNumber(q, times * 10);
}