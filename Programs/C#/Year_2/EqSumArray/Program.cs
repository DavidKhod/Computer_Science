static bool EqSum(int[] arr)
{
    return EqSum(arr,0,arr.Length-1);
}

static bool EqSum(int[] arr, int i,int j)
{
    if(i+1 == j)
        return true;
    if(arr[i] + arr[j] != arr[i+1] + arr[j-1])
        return false;
    return EqSum(arr,i+1,j-1);
}

static bool EqSum(int[] arr, int i)
{
    if(i == arr.Length/2)
        return true;
    if(arr[i] + arr[arr.Length-1-i] != arr[i+1] + arr[arr.Length-1-i])
        return false;
    return EqSum(arr,i+1);
} 