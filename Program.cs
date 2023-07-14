string[] array = {"Hello", "ok", "lipton", "row", "Kirill", "coli", "100", "fillin", ";"};
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) count = count + 1;
}