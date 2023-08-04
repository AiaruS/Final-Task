string [] array1 = new string[5] { "hello", "342", "sum", "5778", "world" };
string [] array2 = new string[array1.Length];
void Method4(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++);
    {
    if (array1[i].Length <= 3)
    {
        array2[count] = array1[i];
        count++;
    }
    }
}