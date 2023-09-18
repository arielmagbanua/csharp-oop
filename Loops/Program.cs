var numbers = new int[] { 2, 4, 5, 6 };
for (int i = 0; i < numbers.Length; i++) {
    Console.WriteLine(numbers[i]);
}

for (int i = 0; i < 5; i++)
{
    Console.Write(i + " ");
}

int num = 0;
while (num < 5) {
    Console.Write(num + " ");
    num++;
}

int x = 0;
do
{
    Console.WriteLine(x);
    x++;
} while (x < 5);
