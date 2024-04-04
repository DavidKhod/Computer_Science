public class Time
{
    public int hour { get; set; }
    public int min { get; set; }
    public int sec { get; set; }

    public Time(int hour, int min,int sec)
    {
        this.hour = hour;
        this.min = min;
        this.sec = sec;
    }

    public int AllToSec()
    {
        return hour * 3600 + min * 60 + sec;
    }

    public override string ToString()
    {
        return $"{hour}:{min}:{sec}";
    }
}

